using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WeNeed1.Model.Enums;
using WeNeed1.Model.Payloads;
using WeNeed1.Service.Database;

namespace WeNeed1.Service.Impl
{
    public class TeamRecommenderService
    {
        private readonly WeNeed1Context _context;
        private readonly IMapper _mapper;

        public TeamRecommenderService(WeNeed1Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task TrainModelAsync()
        {
            var teams = await _context.Teams
                .Include(t => t.UserTeams)
                .ToListAsync();

            var recommendations = new List<SportsTeamRecommendation>();

            foreach (var baseTeam in teams)
            {
                var others = teams.Where(t => t.Id != baseTeam.Id);
                foreach (var compareTeam in others)
                {
                    float similarityScore = CalculateSimilarity(baseTeam, compareTeam);
                    recommendations.Add(new SportsTeamRecommendation
                    {
                        BaseTeamId = baseTeam.Id,
                        RecommendedTeamId = compareTeam.Id,
                        Score = similarityScore
                    });
                }
            }

            _context.SportsTeamRecommendations.RemoveRange(_context.SportsTeamRecommendations);
            await _context.SportsTeamRecommendations.AddRangeAsync(recommendations);
            await _context.SaveChangesAsync();
        }

        private static float CalculateSimilarity(Team a, Team b)
        {
            float score = 0;

            if (a.Sport == b.Sport)
                score += 1.0f;

            var usersA = a.UserTeams.Select(ut => ut.UserId).ToHashSet();
            var usersB = b.UserTeams.Select(ut => ut.UserId).ToHashSet();

            var intersection = usersA.Intersect(usersB).Count();
            var union = usersA.Union(usersB).Count();

            if (union > 0)
                score += (float)intersection / union;

            return score;
        }

        public async Task<List<TeamResponseDto>> GetRecommendationsForUserAsync(int userId)
        {
            var userSports = await _context.UserSports
                .Where(us => us.UserId == userId)
                .Select(us => us.Sport)
                .ToListAsync();

            var userTeams = await _context.UserTeams
                .Where(ut => ut.UserId == userId)
                .Select(ut => ut.TeamId)
                .ToListAsync();

            var recommended = await _context.SportsTeamRecommendations
                .Where(r => userTeams.Contains(r.BaseTeamId))
                .ToListAsync();

            var recommendedTeamIds = recommended.Select(r => r.RecommendedTeamId).Distinct().ToList();

            var recommendedTeams = await _context.Teams
                .Include(t => t.UserTeams)
                .ThenInclude(ut => ut.User)
                .Where(t => recommendedTeamIds.Contains(t.Id) && !userTeams.Contains(t.Id) && t.IsPublic == true)
                .ToListAsync();

            var scoredRecommendations = recommended.Select(r =>
            {
                var team = recommendedTeams.FirstOrDefault(t => t.Id == r.RecommendedTeamId);
                float extraScore = 0;

                if (team != null && team.Sport.HasValue && userSports.Contains(team.Sport.Value))
                    extraScore = 0.5f;

                return new
                {
                    Recommendation = r,
                    TotalScore = r.Score + extraScore
                };
            });

            var sortedIds = scoredRecommendations
                .OrderByDescending(r => r.TotalScore)
                .Select(r => r.Recommendation.RecommendedTeamId)
                .Distinct()
                .Take(5)
                .ToList();

            var result = recommendedTeams
                .Where(t => sortedIds.Contains(t.Id))
                .OrderBy(t => sortedIds.IndexOf(t.Id))
                .Select(t =>
                {
                    var dto = _mapper.Map<TeamResponseDto>(t);
                    dto.IsMember = t.UserTeams.Any(ut => ut.UserId == userId);
                    return dto;
                })
                .ToList();

            return result;
        }
    }
}
