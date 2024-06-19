using System.Reflection;
using static TicTacToe.GameManager.Game;

namespace TicTacToe
{
    internal class GameManager
    {
        public static GameManager Instance { get; private set; } = new();

        private List<Game> _games = new();

        public class Game
        {
            public class PlayerInfo
            {
                public enum PlayerState
                {
                    Turn,
                    Waiting
                }

                public PlayerInfo(string userId, PlayerState state)
                {
                    UserId = userId;
                    State = state;
                }

                public string UserId { get; private set; }
                public PlayerState State { get; private set; }
            }


            public class PlayingFieldInfo
            {
                public enum CellState
                {
                    Cross,
                    Circle,
                    None
                }

                public CellState[] Cells { get; private set; } =
                {
                    CellState.None, CellState.None, CellState.None,
                    CellState.None, CellState.None, CellState.None,
                    CellState.None, CellState.None, CellState.None
                };
            }

            public Game(PlayerInfo playerOne, PlayerInfo playerTwo)
            {
                PlayerOne = playerOne;
                PlayerTwo = playerTwo;
                FieldInfo = new();
            }

            public PlayerInfo PlayerOne { get; private set; }
            public PlayerInfo PlayerTwo { get; private set; }

            public PlayingFieldInfo FieldInfo { get; private set; }

            public void Start()
            {
                var baseMessage = "Вы запустили новую игру с [%userId%]\nВы ходите %turn%\n/turn 1-9 - совершить ход";

                if (PlayerOne.State == PlayerInfo.PlayerState.Turn)
                {
                    TelegramBot.Instance.SendMessage(PlayerOne.UserId, baseMessage.Replace("%userId%", PlayerTwo.UserId).Replace("%turn%", "первым"));
                    TelegramBot.Instance.SendMessage(PlayerTwo.UserId, baseMessage.Replace("%userId%", PlayerOne.UserId).Replace("%turn%", "вторым"));
                }
                else
                {
                    TelegramBot.Instance.SendMessage(PlayerTwo.UserId, baseMessage.Replace("%userId%", PlayerOne.UserId).Replace("%turn%", "первым"));
                    TelegramBot.Instance.SendMessage(PlayerOne.UserId, baseMessage.Replace("%userId%", PlayerTwo.UserId).Replace("%turn%", "вторым"));
                }

                var image = GameDrawer.Instance.Draw(this);

                TelegramBot.Instance.SendImage(PlayerOne.UserId, image);
                TelegramBot.Instance.SendImage(PlayerTwo.UserId, image);

                Program.MainForm.UpdateGameView(image);
            }
        }

        public void StartNewGame(string firstPlayerId, string secondPlayerId)
        {
            var game = new Game(
                new PlayerInfo(firstPlayerId, PlayerInfo.PlayerState.Turn),
                new PlayerInfo(secondPlayerId, PlayerInfo.PlayerState.Waiting)
            );
            game.Start();

            _games.Add(game);
        }
    }
}