
using MongoDB.Driver;
using GamesCatalog.DTO;
using GamesCatalog.Interfaces;
namespace GamesCatalog.Repositories
{
        public class GameRepository : IGameRepository
        {
            private readonly List<Game> _games = new(); // Simulating DB

            public Task<IEnumerable<Game>> GetAllAsync() => Task.FromResult(_games.AsEnumerable());
            public Task<Game> GetByIdAsync(int id)
            {
                return Task.FromResult(_games.FirstOrDefault(g => g.Id == id));
            }

            public Task AddAsync(Game game) { _games.Add(game); return Task.CompletedTask; }
            public Task UpdateAsync(Game game) { var index = _games.FindIndex(g => g.Id == game.Id); if (index != -1) _games[index] = game; return Task.CompletedTask; }
            public Task DeleteAsync(int id) { _games.RemoveAll(g => g.Id == id); return Task.CompletedTask; }
    }
