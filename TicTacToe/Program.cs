using System;

namespace TicTacToe
{
    class Program
    {

        static char[,] numberPlacement =
            {
                { '1', '2', '3' }, //Row 0
                { '4', '5', '6' }, //Row 1
                { '7', '8', '9' }  //Row 2
            };

       

        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2; //Player 1 starts
            int input = 0;
            bool inputCorrect = true;

            do
            {
                

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if(player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }

                setField();
                #region
                // Check winning conditions

                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (((numberPlacement[0, 0] == playerChar) && (numberPlacement[0, 1] == playerChar) && (numberPlacement[0, 2] == playerChar))
                        || ((numberPlacement[1, 0] == playerChar) && (numberPlacement[1, 1] == playerChar) && (numberPlacement[1, 2] == playerChar))
                        || ((numberPlacement[2, 0] == playerChar) && (numberPlacement[2, 1] == playerChar) && (numberPlacement[2, 2] == playerChar))
                        || ((numberPlacement[0, 0] == playerChar) && (numberPlacement[1, 0] == playerChar) && (numberPlacement[2, 0] == playerChar))
                        || ((numberPlacement[0, 2] == playerChar) && (numberPlacement[1, 2] == playerChar) && (numberPlacement[2, 2] == playerChar))
                        || ((numberPlacement[0, 0] == playerChar) && (numberPlacement[1, 1] == playerChar) && (numberPlacement[2, 2] == playerChar))
                        || ((numberPlacement[0, 2] == playerChar) && (numberPlacement[1, 1] == playerChar) && (numberPlacement[2, 0] == playerChar))
                        || ((numberPlacement[0, 1] == playerChar) && (numberPlacement[1, 1] == playerChar) && (numberPlacement[2, 1] == playerChar))
                        )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 has won!");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has won!");
                        }

                        Console.WriteLine("Please press any key to reset the game.");
                        Console.ReadKey();

                        resetField();
                        break;

                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("\nLooks like nobody won. Try again.");
                        Console.ReadKey();
                        resetField();
                        break;
                    }
                   
             
                }
                #endregion
                
                #region
                // Test if field is already taken.
                do
                {
                    Console.Write("\nPlayer {0}: Choose your field! ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());            //The good old original, and change it.
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    if ((input == 1) && (numberPlacement[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (numberPlacement[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (numberPlacement[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (numberPlacement[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (numberPlacement[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (numberPlacement[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (numberPlacement[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (numberPlacement[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (numberPlacement[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect input! Please use another field");
                        inputCorrect = false;
                    }

                    
                } while (!inputCorrect);
                #endregion

            } while (true);
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        public static void resetField()
        {
             char[,] initialNumberPlacement =
            {
                { '1', '2', '3' }, //Row 0
                { '4', '5', '6' }, //Row 1
                { '7', '8', '9' }  //Row 2
            };

            numberPlacement = initialNumberPlacement;
            setField();
            turns = 0;
        }

        public static void setField()

        {
            Console.Clear();                                //Reset the board.
            Console.WriteLine("         |       |       ");
            Console.WriteLine("     {0}   |   {1}   |    {2}", numberPlacement[0, 0], numberPlacement[0, 1], numberPlacement[0, 2]);
            Console.WriteLine("  _______|_______|________");
            Console.WriteLine("         |       |       ");
            Console.WriteLine("     {0}   |   {1}   |    {2}", numberPlacement[1, 0], numberPlacement[1, 1], numberPlacement[1, 2]);
            Console.WriteLine("  _______|_______|________");
            Console.WriteLine("         |       |       ");
            Console.WriteLine("     {0}   |   {1}   |    {2}", numberPlacement[2, 0], numberPlacement[2, 1], numberPlacement[2, 2]);
            Console.WriteLine("         |       |       ");
            turns++;
        }

        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
            {
                playerSign = 'X';
            }

            else if (player == 2)
            {
                playerSign = 'O';
            }

            switch (input)  //This is the input switch to make sure it was player one. 
            {
                case 1: numberPlacement[0, 0] = playerSign; break;
                case 2: numberPlacement[0, 1] = playerSign; break;
                case 3: numberPlacement[0, 2] = playerSign; break;
                case 4: numberPlacement[1, 0] = playerSign; break;
                case 5: numberPlacement[1, 1] = playerSign; break;
                case 6: numberPlacement[1, 2] = playerSign; break;
                case 7: numberPlacement[2, 0] = playerSign; break;
                case 8: numberPlacement[2, 1] = playerSign; break;
                case 9: numberPlacement[2, 2] = playerSign; break;
            }
        }
    }
}
