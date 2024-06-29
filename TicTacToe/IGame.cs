namespace TicTacToe
{
    internal interface IGame
    {
        public void Start();
        public Game.TurnStatus MakeTurn(string playerId, int cell);
        public void End();
    }
}