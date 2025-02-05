using GamesCatalog.DTO;
using GamesCatalog.Interfaces;

namespace GamesCatalog.Services
{
    public class BusinessService
    {
        private readonly IGameRepository _gameRepository;

        public BusinessService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public IEnumerable<Game> GetAllGames()
        {
            return _gameRepository.GetAll();
        }

        public Game GetGameById(int id)
        {
            return _gameRepository.GetById(id);
        }
    }
}

