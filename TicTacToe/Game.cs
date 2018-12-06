using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Game
    {
        string[,] board = new string[3, 3];                                   //This is the board.
        

        //Setting the play field.
       

        public void HumanInteraction()
        {
            String playerOne;
            String PlayerTwo;

            int playerOneMarking, playerTwoMarking;

            Console.WriteLine("Player One, please enter a zone.");
            playerOne = Console.ReadLine();
            playerOneMarking = int.Parse(playerOne);

            switch (playerOneMarking)
            {
                case 1:
                    board[0, 0] = "X";
                    break;
            }
            

            Console.WriteLine("Player Two, please enter a zone.");
            PlayerTwo = Console.ReadLine();
            playerTwoMarking = int.Parse(PlayerTwo);


            Console.WriteLine("Player Two, please enter a zone.");
            PlayerTwo = Console.ReadLine();

            Console.WriteLine();

        }

    }
}
