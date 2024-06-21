using static TicTacToe.GameManager.Game;

namespace TicTacToe
{
    internal class GameManager
    {
        public static GameManager Instance { get; private set; } = new();

        private List<Game> _games = new();

        public class Game
        {
            public enum TurnStatus
            {
                Successful,
                NoTurn,
                NoAbilityToTurn
            }

            public class PlayerInfo
            {
                public enum PlayerState
                {
                    Turn,
                    Waiting
                }

                public enum PlayerChar
                {
                    Cross,
                    Circle
                }

                public PlayerInfo(string userId, PlayerState state, PlayerChar playerChar)
                {
                    UserId = userId;
                    State = state;
                    Char = playerChar;
                }

                public string UserId { get; private set; }
                public PlayerState State { get; set; }
                public PlayerChar Char { get; private set; }
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
            }

            public TurnStatus MakeTurn(string playerId, int cell)
            {
                var player = GetPlayerById(playerId);

                if (player.State != PlayerInfo.PlayerState.Turn)
                {
                    return TurnStatus.NoTurn;
                }

                cell--;

                if (FieldInfo.Cells[cell] != PlayingFieldInfo.CellState.None)
                {
                    return TurnStatus.NoAbilityToTurn;
                }

                if (player.Char == PlayerInfo.PlayerChar.Circle)
                    FieldInfo.Cells[cell] = PlayingFieldInfo.CellState.Circle;
                else
                    FieldInfo.Cells[cell] = PlayingFieldInfo.CellState.Cross;

                CheckForWin(cell, player);
                SwapState();

                return TurnStatus.Successful;
            }

            public PlayerInfo GetPlayerById(string playerId) => (PlayerOne.UserId == playerId) ? PlayerOne : PlayerTwo;

            private void SwapState()
            {
                if (PlayerOne.State == PlayerInfo.PlayerState.Turn)
                {
                    PlayerOne.State = PlayerInfo.PlayerState.Waiting;
                    PlayerTwo.State = PlayerInfo.PlayerState.Turn;
                }
                else
                {
                    PlayerOne.State = PlayerInfo.PlayerState.Turn;
                    PlayerTwo.State = PlayerInfo.PlayerState.Waiting;
                }
            }

            private void CheckForWin(int cell, PlayerInfo player)
            {
                var cells = FieldInfo.Cells;
                var playerChar = (player.Char == PlayerInfo.PlayerChar.Circle) ? PlayingFieldInfo.CellState.Circle : PlayingFieldInfo.CellState.Cross;

                void Win()
                {
                    TelegramBot.Instance.Win(player.UserId);
                    Instance._games.Remove(this);
                }

                bool Check(int i) => cells[i] == playerChar;

                switch (cell)
                {
                    case 0:
                        if (Check(1) && Check(2))
                            Win();
                        else if (Check(3) && Check(6))
                            Win();
                        else if (Check(4) && Check(8))
                            Win();
                        break;

                    case 1:
                        if (Check(0) && Check(2))
                            Win();
                        else if (Check(4) && Check(7))
                            Win();
                        break;

                    case 2:
                        if (Check(0) && Check(1))
                            Win();
                        else if (Check(5) && Check(8))
                            Win();
                        else if (Check(4) && Check(6))
                            Win();
                        break;

                    case 3:
                        if (Check(0) && Check(6))
                            Win();
                        else if (Check(4) && Check(5))
                            Win();
                        break;

                    case 4:
                        if (Check(0) && Check(8))
                            Win();
                        else if (Check(6) && Check(2))
                            Win();
                        else if (Check(1) && Check(7))
                            Win();
                        else if (Check(3) && Check(5))
                            Win();
                        break;

                    case 5:
                        if (Check(2) && Check(8))
                            Win();
                        else if (Check(3) && Check(4))
                            Win();
                        break;

                    case 6:
                        if (Check(0) && Check(3))
                            Win();
                        else if (Check(7) && Check(8))
                            Win();
                        else if (Check(4) && Check(2))
                            Win();
                        break;

                    case 7:
                        if (Check(6) && Check(8))
                            Win();
                        else if (Check(4) && Check(1))
                            Win();
                        break;

                    case 8:
                        if (Check(6) && Check(7))
                            Win();
                        else if (Check(2) && Check(5))
                            Win();
                        else if (Check(4) && Check(0))
                            Win();
                        break;
                }
            }
        }

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