using GamesCatalog.DTO;

namespace GamesCatalog.Interfaces
{
    public interface IGameService
    {
       Game GetGameDetails(string id);
       IEnumerable<Game> GetGamesByGenre();
    }
}
