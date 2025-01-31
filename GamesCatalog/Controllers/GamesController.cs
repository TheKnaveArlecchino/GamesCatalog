using Microsoft.AspNetCore.Mvc;

namespace GamesCatalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesController : ControllerBase
    {

        private readonly ILogger<GamesController> _logger;

        public GamesController(IGameService _gameService)
        {
           _gameService = gameService;
        }

        [HttpGet]
        
        
    }
}
