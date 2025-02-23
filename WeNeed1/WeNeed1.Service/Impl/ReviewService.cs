using AutoMapper;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service.Database;

namespace WeNeed1.Service.Impl;

public class ReviewService : BaseCRUDService<ReviewResponseDto, Review, ReviewSearchObject, ReviewRequestDto, ReviewRequestDto>, IReviewService
{
    private readonly IUserService _userService;
    public ReviewService(WeNeed1Context context, IMapper mapper, IUserService userService) : base(context, mapper)
    {
        _userService = userService;
    }

    public async Task<ReviewResponseDto> CreateReview(int sportCenterId, ReviewRequestDto request)
    {
        var entity = _mapper.Map<Review>(request);
        entity.SportsCenterId = sportCenterId;
        entity.Created = DateTime.UtcNow;
        var currentUser = await _userService.GetCurrentUserAsync();

        if (currentUser == null)
        {
            throw new Exception("No logged-in user found.");
        }
        entity.UserId = currentUser.Id;

        await _context.Reviews.AddAsync(entity);
        await _context.SaveChangesAsync();

        return _mapper.Map<ReviewResponseDto>(entity);
    }

    public override IQueryable<Review> AddFilter(IQueryable<Review> query, ReviewSearchObject search)
    {
        if (search?.SportsCenterId.HasValue == true)
        {
            query = query.Where(x => x.SportsCenterId == search.SportsCenterId);
        }

        return query;
    }
}