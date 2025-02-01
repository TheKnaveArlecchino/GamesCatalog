using GamesCatalog.DTO;

namespace GamesCatalog.Services
{
    public interface IBusinessService
    {
        Task<IEnumerable<Game>> GetAllGamesAsync();
        Task<Game> GetGameByIdAsync(int id);
    }
}
