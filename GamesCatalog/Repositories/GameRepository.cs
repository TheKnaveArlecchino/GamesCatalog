
using MongoDB.Driver;
using GamesCatalog.DTO;
using GamesCatalog.Interfaces;

namespace GamesCatalog.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly List<Game> _games = new();

        public Game GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Game game)
        {
            _games.Add(game);
        }

        public void Update(Game game)
        {
            var index = _games.FindIndex(g => g.Id == game.Id);
            if (index != -1)
                _games[index] = game;
        }

        public void Delete(int id)
        {
            _games.RemoveAll(g => g.Id == id);
        }

        public IEnumerable<Game> GetAll()
        {
            throw new NotImplementedException();
        }
    }
