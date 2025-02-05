using GamesCatalog.DTO;

namespace GamesCatalog.Interfaces
{
    public interface IGameRepository
    {
        Game GetById(int id);
        IEnumerable<Game> GetAll();
        Add(Game game);
        Update(Game game);
        Delete(int id);
    }
}
