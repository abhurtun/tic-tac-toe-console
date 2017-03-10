using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class Game
    {
        //possible sectors on the board
        private static readonly string[] Board = new[] {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

        //define the winning sector combinations
        private static readonly string[][] WinningMoves = new[]
        {
            // rows
            new[] { "1", "2", "3" },
            new[] { "4", "5", "6" },
            new[] { "7", "8", "9" },
            // columns
            new[] { "1", "4", "7" },
            new[] { "2", "5", "8" },
            new[] { "3", "6", "9" },
            // diagonals
            new[] { "1", "5", "9" },
            new[] { "3", "5", "7" }
        };

        //record the players moves
        private readonly IDictionary<string, IList<string>> moves = new Dictionary<string, IList<string>>();

        //set the game structure 
        public Game()
        {
            //Player that chooses X starts
            CurrentPlayer = "X";
            moves["X"] = new List<string>();
            moves["O"] = new List<string>();
        }

        //get the current player
        public virtual string CurrentPlayer { get; private set; }

        //record player move and switch player
        public virtual void MakeMove(string move)
        {
            RecordMoveFor(CurrentPlayer, move);
            ChangePlayers();
        }

        //get all the moves for a player
        public virtual string[] MovesFor(string player)
        {
            return moves[player].ToArray();
        }

        //return the sectors availble to move into
        public virtual string[] AvailableMoves
        {
            get { return Board.Except(MovesFor("X")).Except(MovesFor("O")).ToArray(); }
        }

        //check sector is not already taken
        public bool IsAllowedMove(string move)
        {
            return AvailableMoves.Contains(move);
        }

        //check game status
        public virtual bool IsOver()
        {
            return IsDraw() || Winner != "";
        }

        public bool IsDraw()
        {
            return Winner == "" && !AvailableMoves.Any();
        }
        // get the name of the winner
        public virtual string Winner
        {
            get
            {
                if (PlayerHasWon("X"))
                    return "X";
                if (PlayerHasWon("O"))
                    return "O";
                return "";
            }
        }

        private void RecordMoveFor(string player, string move)
        {
            moves[player].Add(move);
        }

        private void ChangePlayers()
        {
            CurrentPlayer = (CurrentPlayer == "X" ? "O" : "X");
        }

        private bool PlayerHasWon(string player)
        {
            return WinningMoves.Any(setOfMoves => HasAllMoves(player, setOfMoves));
        }

        private bool HasAllMoves(string player, IEnumerable<string> setOfMoves)
        {
            return setOfMoves.All(move => MovesFor(player).Contains(move));
        }
    }
}
