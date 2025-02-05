using GamesCatalog.DTO;
using GamesCatalog.Interfaces;

namespace GamesCatalog.Services
{
    public class GameService(IGameRepository gameRepository) : IGameService
    {
        private readonly IGameRepository _gameRepository = gameRepository;

        public Game GetGameDetails(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> GetGamesByGenre()
        {
            throw new NotImplementedException();
        }
    }
