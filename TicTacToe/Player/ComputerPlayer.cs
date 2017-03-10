using System;

namespace TicTacToe
{
    //class implements IPlayer
    //The computer player randomly moves
    public class ComputerPlayer : IPlayer
    {
        private readonly Game game;

        public ComputerPlayer(Game game)
        {
            this.game = game;
        }

        //overridde and implement the next random movement
        public virtual string GetNextMove()
        {
            var random = new Random();
            var moveIndex = random.Next(0, game.AvailableMoves.Length); //Returns a nonnegative random integer that is less than the specified maximum.
            return game.AvailableMoves[moveIndex];
        }
    }
}
