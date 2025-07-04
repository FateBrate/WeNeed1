using Microsoft.EntityFrameworkCore;
using WeNeed1.Service.Database;

namespace WeNeed1.Service.Impl
{
    public class SportsCenterRecommenderService
    {
        private readonly WeNeed1Context _context;

        public SportsCenterRecommenderService(WeNeed1Context context)
        {
            _context = context;
        }

        public async Task TrainModelAsync()
        {
            var centers = await _context.SportsCenters
                .Include(sc => sc.SportsFields)
                .Include(sc => sc.Reviews)
            .ToListAsync();

            var recommendations = new List<SportsCenterRecommendation>();

            foreach (var baseCenter in centers)
            {
                var others = centers.Where(c => c.Id != baseCenter.Id);
                foreach (var compareCenter in others)
                {
                    float similarityScore = CalculateSimilarity(baseCenter, compareCenter);
                    recommendations.Add(new SportsCenterRecommendation
                    {
                        BaseSportsCenterId = baseCenter.Id,
                        RecommendedSportsCenterId = compareCenter.Id,
                        Score = similarityScore
                    });
                }
            }

            _context.SportsCenterRecommendations.RemoveRange(_context.SportsCenterRecommendations);
            await _context.SportsCenterRecommendations.AddRangeAsync(recommendations);
            await _context.SaveChangesAsync();
        }

        private float CalculateSimilarity(SportsCenter a, SportsCenter b)
        {
            float score = 0;

            score += 1 - Math.Abs(a.SportsFields.Count - b.SportsFields.Count) / 10f;

            var avgA = a.Reviews.Any() ? a.Reviews.Average(r => (double)r.Rating) : 0;
            var avgB = b.Reviews.Any() ? b.Reviews.Average(r => (double)r.Rating) : 0;
            score += 1 - (float)Math.Abs(avgA - avgB) / 5f;

            return score;
        }

        public async Task<List<SportsCenter>> GetRecommendationsForUserAsync(int userId)
        {
            var recentReservation = await _context.Reservations
                .Where(r => r.UserId == userId)
                .OrderByDescending(r => r.StartTime)
                .Include(r => r.SportsField)
                    .ThenInclude(sf => sf.SportsCenter)
                .FirstOrDefaultAsync();

            if (recentReservation != null)
            {
                var baseCenterId = recentReservation.SportsField?.SportsCenterId;
                return await _context.SportsCenterRecommendations
                    .Where(r => r.BaseSportsCenterId == baseCenterId)
                    .OrderByDescending(r => r.Score)
                    .Select(r => r.RecommendedSportsCenter!)
                    .Take(5)
                    .ToListAsync();
            }

            return await _context.SportsCenters
                .Where(sc => sc.Reviews.Any())
                .OrderByDescending(sc => sc.Reviews.Average(r => r.Rating))
                .Take(5)
                .ToListAsync();
        }
    }

}
