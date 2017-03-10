using System;
using System.Linq;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class ComputerPlayerTest
    {
        [Test]
        public void GetNextMoveIsRandomWithinAllowedMoves()
        {
            var game = new Game();
            var random = new Random();
            var numberOfMoves = random.Next(1, 5); 

                var player = new ComputerPlayer(game);
                var allowedMoves = game.AvailableMoves;

                var move = player.GetNextMove();

                Assert.That(allowedMoves.Contains(move));

        }

    }
}
