using static TicTacToe.Game;

namespace TicTacToe
{
    internal class GameManager
    {
        public static GameManager Instance { get; private set; } = new();

        private List<Game> _games = new();

        public void EndGame(Game game) => _games.Remove(game);

        public void StartNewGame(string firstPlayerId, string secondPlayerId)
        {
            Game game;
            
            if (new Random().Next(0, 100) > 50)
                game = new Game(
                new PlayerInfo(firstPlayerId, PlayerInfo.PlayerState.Turn, PlayerInfo.PlayerChar.Cross),
                new PlayerInfo(secondPlayerId, PlayerInfo.PlayerState.Waiting, PlayerInfo.PlayerChar.Circle)
                );
            else
                game = new Game(
                    new PlayerInfo(firstPlayerId, PlayerInfo.PlayerState.Waiting, PlayerInfo.PlayerChar.Circle),
                    new PlayerInfo(secondPlayerId, PlayerInfo.PlayerState.Turn, PlayerInfo.PlayerChar.Cross)
                );

            _games.Add(game);
            game.Start();
        }

        public Game? GetGameByPlayerId(string userId) => _games.Find(game => game.PlayerOne.UserId == userId || game.PlayerTwo.UserId == userId);
    }
}