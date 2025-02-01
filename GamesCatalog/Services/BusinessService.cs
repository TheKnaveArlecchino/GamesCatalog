using GamesCatalog.DTO;
using GamesCatalog.Interfaces;

namespace GamesCatalog.Services
{
    public class BusinessService
    {
        private readonly IGameRepository _gameRepository;
        public BusinessService(IGameRepository gameRepository) { _gameRepository = gameRepository; }
        public Task<IEnumerable<Game>> GetAllGamesAsync() => _gameRepository.GetAllAsync();
        public Task<Game> GetGameByIdAsync(int id) => _gameRepository.GetByIdAsync(id);
    }
}
}
