using Microsoft.AspNetCore.Mvc;
using WeNeed1.Service.Impl;

namespace WeNeed1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportCenterRecommenderController : ControllerBase
    {
        private readonly SportsCenterRecommenderService _recommenderService;

        public SportCenterRecommenderController(SportsCenterRecommenderService recommenderService)
        {
            _recommenderService = recommenderService;
        }

        [HttpPost("train")]
        public async Task<IActionResult> Train()
        {
            await _recommenderService.TrainModelAsync();
            return Ok("Model treniran.");
        }

        [HttpGet("recommend/{userId}")]
        public async Task<IActionResult> Recommend(int userId)
        {
            var result = await _recommenderService.GetRecommendationsForUserAsync(userId);
            return Ok(result);
        }
    }
}
