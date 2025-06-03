using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service;

namespace WeNeed1.Controllers
{
    [ApiController]
    [Authorize]
    public class MatchController : BaseCRUDController<MatchResponseDto, MatchSearchObject, MatchRequestDto, MatchRequestDto>
    {
        private readonly IMatchService _matchService;

        public MatchController(ILogger<BaseController<MatchResponseDto, MatchSearchObject>> logger,
            IMatchService matchService)
            : base(logger, matchService)
        {
            _matchService = matchService;
        }
        
    }
}