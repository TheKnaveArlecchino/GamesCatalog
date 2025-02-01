using Microsoft.AspNetCore.Mvc;
using GamesCatalog.Services;

namespace GamesCatalog.Controllers
{

    [ApiController]
    [Route("api/games")]
    public class GamesController : ControllerBase
    {
        private readonly IBusinessService _businessService;
        public GamesController(IBusinessService businessService) { _businessService = businessService; }

        [HttpGet]
        public async Task<IActionResult> GetAllGames() => Ok(await _businessService.GetAllGamesAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGameById(int id)
        {
            var game = await _businessService.GetGameByIdAsync(id);
            return game == null ? NotFound() : Ok(game);
        }
    }
}
}
