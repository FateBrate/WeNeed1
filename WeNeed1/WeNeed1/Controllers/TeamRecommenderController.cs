using Microsoft.AspNetCore.Mvc;
using WeNeed1.Service.Impl;

namespace WeNeed1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamRecommenderController : ControllerBase
    {
        private readonly TeamRecommenderService _recommenderService;

        public TeamRecommenderController(TeamRecommenderService recommenderService)
        {
            _recommenderService = recommenderService;
        }

        [HttpPost("train")]
        public async Task<IActionResult> Train()
        {
            await _recommenderService.TrainModelAsync();
            return Ok("Team recommendation model trained.");
        }

        [HttpGet("recommend/{userId}")]
        public async Task<IActionResult> Recommend(int userId)
        {
            var result = await _recommenderService.GetRecommendationsForUserAsync(userId);
            return Ok(result);
        }
    }
}
