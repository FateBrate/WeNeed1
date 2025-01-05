using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;

namespace WeNeed1.Service;

public interface IReviewService :ICRUDService<ReviewResponseDto,ReviewSearchObject,ReviewRequestDto,ReviewRequestDto>
{
    Task<ReviewResponseDto> CreateReview(int sportCenterId, ReviewRequestDto request);
}