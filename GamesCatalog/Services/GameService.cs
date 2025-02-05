using GamesCatalog.DTO;
using GamesCatalog.Interfaces;

namespace GamesCatalog.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        public GameService(IGameRepository gameRepository) {
            _gameRepository = gameRepository;
    }
        public Game GetGameDetails(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> GetGamesByGenre()
        {
            throw new NotImplementedException();
        }
    }
