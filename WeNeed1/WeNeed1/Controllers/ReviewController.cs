using Microsoft.AspNetCore.Mvc;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service;

namespace WeNeed1.Controllers
{
    [ApiController]
    public class ReviewController : BaseCRUDController<ReviewResponseDto, ReviewSearchObject, ReviewRequestDto,
        ReviewRequestDto>
    {
        private readonly IReviewService _reviewService;

        public ReviewController(ILogger<BaseController<ReviewResponseDto, ReviewSearchObject>> logger,
            IReviewService service)
            : base(logger, service)
        {
            _reviewService = service;
        }

        [HttpPost("sportCenter/{sportsCenterId}")]
        public Task<ReviewResponseDto> Insert(int sportsCenterId, ReviewRequestDto request)
        {
            return _reviewService.CreateReview(sportsCenterId,request);
        }
    }
}