using GamesCatalog.Interfaces;
using GamesCatalog.Services;

namespace GamesCatalog.Tests
{
    public class GameServiceTests
    {
        private readonly Mock<IGameRepository> _gameRepositoryMock;
        private readonly GameService _gameService;

        public GameServiceTests()
        {
            _gameRepositoryMock = new Mock<IGameRepository>();
            _gameService = new GameService(_gameRepositoryMock.Object);
        }
    }