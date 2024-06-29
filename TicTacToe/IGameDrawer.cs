namespace TicTacToe;

internal interface IGameDrawer
{
    public Task<Image> Draw(Game game);
}