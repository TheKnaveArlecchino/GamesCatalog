using GamesCatalog.DTO;

namespace GamesCatalog.Interfaces
{
    public interface IGameRepository
    {
        Task<Game> GetByIdAsync(int id);
        Task<IEnumerable<Game>> GetAllAsync();
        Task AddAsync(Game game);
        Task UpdateAsync(Game game);
        Task DeleteAsync(int id);
    }
}
