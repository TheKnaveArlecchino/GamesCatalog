using GamesCatalog.DTO;

namespace GamesCatalog.Services
{
    public interface IBusinessService
    {
        IEnumerable<Game> GetAllGames();
        Game GetGameById(int id);
    }
}
