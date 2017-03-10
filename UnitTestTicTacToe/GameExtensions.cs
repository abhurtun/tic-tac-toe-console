using NUnit.Framework;

namespace TicTacToe.Tests
{
    public static class GameExtensions
    {
        //extention methos for game type to easily make mutiple moves
        public static void MakeMoves(this Game game, params string[] moves)
        {
            foreach (var move in moves)
            {
                var player = move.Substring(0, 1);
                var square = move.Substring(1);
                Assert.That(player, Is.EqualTo(game.CurrentPlayer));
                game.MakeMove(square);
            }
        }
    }
}
