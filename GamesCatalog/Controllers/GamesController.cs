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
        public IActionResult GetAllGames()
        {
            var games = _businessService.GetAllGames();
            return Ok(games);
        }

        [HttpGet("{id}")]
        public IActionResult GetGameById(int id)
        {
            var game = _businessService.GetGameById(id);
            return game != null ? Ok(game) : NotFound();
        }

    }
}
}
