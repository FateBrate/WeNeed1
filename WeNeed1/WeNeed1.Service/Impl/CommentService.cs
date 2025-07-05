using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeNeed1.Model.Exceptions;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service.Database;

namespace WeNeed1.Service.Impl
{
    public class CommentService : BaseCRUDService<CommentResponseDto, Comment, CommentSearchObject, CommentRequestDto, CommentRequestDto>, ICommentService
    {
        private readonly IUserService _userService;

        public CommentService(WeNeed1Context context, IMapper mapper, IUserService userService)
            : base(context, mapper)
        {
            _userService = userService;
        }

        public override async Task<CommentResponseDto> Insert(CommentRequestDto request)
        {
            var currentUser = await _userService.GetCurrentUserAsync();
            if (currentUser == null)
            {
                throw new Exception("No logged-in user found.");
            }
            
            var matchExist = await _context.Matches.AnyAsync(m => m.Id == request.MatchId);

            if (!matchExist)
            {
                throw new UserException("Match does not exist.");
            }
            
            var entity = _mapper.Map<Comment>(request);
            entity.UserId = currentUser.Id;
            entity.Created = DateTime.UtcNow;

            await _context.Comments.AddAsync(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<CommentResponseDto>(entity);
        }

        public override IQueryable<Comment> AddFilter(IQueryable<Comment> query, CommentSearchObject search)
        {
            query = query.Include(c => c.User);
            if (search.MatchId.HasValue)
            {
                query = query.Where(c => c.MatchId == search.MatchId.Value);
            }
            return query;
        }
    }
}