using System;
namespace RockPaperScissors
{
    public class RockPaperScissorsEvaluator
    {
        /// <summary>
        /// Gets the winning move.
        /// </summary>
        /// <returns>The winning move.</returns>
        /// <param name="handsign">Handsign.</param>
        public string GetWinningMove(string handsign)
        {
            switch (handsign.ToUpper())
            {
                case "ROCK":
                    return "PAPER";
                case "PAPER":
                    return "SCISSORS";
                case "SCISSORS":
                    return "ROCK";
                default:
                    return "Unexpected Error";
            }
        }

        /// <summary>
        /// Gets the winner.
        /// </summary>
        /// <returns>The winner.</returns>
        /// <param name="handSignPlayer1">Handsign player1.</param>
        /// <param name="handSignPlayer2">Handsign player2.</param>
        public string GetWinner(string handSignPlayer1, string handSignPlayer2)
        {
            if (GetWinningMove(handSignPlayer1).Equals(handSignPlayer2))
            {
                return handSignPlayer2; //player 1 loses to player 2
            }
            else if (GetWinningMove(handSignPlayer2).Equals(handSignPlayer1))
            {
                return handSignPlayer2; //player 2 loses to player 1
            }
            else
            {
                return "Tie!";
            }
        }

    }
}


