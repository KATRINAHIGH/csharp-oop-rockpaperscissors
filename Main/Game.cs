using System;

namespace RockPaperScissors
{
    public class Game
    {

        private Player humanPlayer;
        private Player cpuPlayer;
        private static PrintUtil printUtil = new PrintUtil();

        public void startGame()
        {
            var name = printUtil.GreetOpponent();
            //create players
            this.humanPlayer = new Player(name);
            this.cpuPlayer = new Player("CPU");
            //start game message
            printUtil.StartGameMessage(humanPlayer);
            //Get users hand, Note check for valid entry
            var humanHandSign = printUtil.ChooseHandSign();
            this.humanPlayer.HandSign = humanHandSign;
            //Generate a random hand for computer
            this.cpuPlayer.HandSign = HandSign.MapRandomToMove();
            //compare choices
            //Declare winner
            Console.WriteLine(HandSign.GetWinner(this.humanPlayer, this.cpuPlayer));
          


            //Give option to play again, do while loop run as long as true, 

        }
    }
}


