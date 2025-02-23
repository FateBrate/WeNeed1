using Microsoft.AspNetCore.Mvc;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service;

namespace WeNeed1.Controllers
{
    [ApiController]
    public class CommentController : BaseCRUDController<CommentResponseDto, CommentSearchObject, CommentRequestDto, CommentRequestDto>
    {
        public CommentController(ILogger<BaseController<CommentResponseDto, CommentSearchObject>> logger, ICommentService service)
            : base(logger, service)
        {
        }
    }
}