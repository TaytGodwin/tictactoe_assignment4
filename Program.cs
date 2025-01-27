
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        //• Welcome the user to the game
        Console.WriteLine("Welcome to the game of Tic Tac Toe");
        //• Create a game board array to store the players’ choices
        char[,] aaBoard = new char[3, 3];
        //• Ask each player in turn for their choice and update the game board array
        // Check if there is a winner for each loop
        while (DisplayWinner(aaBoard)[0] == false)
        {
            // Column and row variables
            int iColumnNum = 0;
            int iRowNum = 0;

            // This is to check if the array is already filled in that position and not let them continue until they get it right
            bool bAlreadyFilled = true;
            while (bAlreadyFilled == true)
            {

                // Get player input
                Console.WriteLine("The board is as follows:");
                Console.WriteLine(PrintBoard(aaBoard));
                Console.WriteLine("Player 1, please choose which column you want to put your X in. Input a number from 1-3 (example: 2)");
                iColumnNum = checkInteger(Console.ReadLine());
                Console.WriteLine("Player 1, please choose which row you want to put your X in. Input a number from 1-3 (example: 2)");
                iRowNum = checkInteger(Console.ReadLine());

                // Check if that position has been filled 
                if (aaBoard[iRowNum - 1, iColumnNum -1] is '\0')
                {
                    bAlreadyFilled = false;
                }
                else
                {
                    Console.WriteLine("You must enter an X where there is not already a value");
                }
            }

            // Put the value in the array
            aaBoard[iRowNum - 1, iColumnNum - 1] = 'X';

            // Check if there is a winner now
            if (DisplayWinner(aaBoard)[0] == false) // if false, get second player input, if not it will exit this loop automatically
            {

                // This is to check if the array is already filled in that position and not let them continue until they get it right
                bAlreadyFilled = true;
                while (bAlreadyFilled == true)
                {

                    // Get player input
                    Console.WriteLine("The board is as follows:");
                    Console.WriteLine(PrintBoard(aaBoard));
                    Console.WriteLine("Player 2, please choose which column you want to put your X in. Input a number from 1-3 (example: 2)");
                    iColumnNum = checkInteger(Console.ReadLine());
                    Console.WriteLine("Player 2, please choose which row you want to put your X in. Input a number from 1-3 (example: 2)");
                    iRowNum = checkInteger(Console.ReadLine());

                    // Check if that position has been filled 
                    if (aaBoard[iRowNum - 1, iColumnNum - 1] is '\0')
                    {
                        bAlreadyFilled = false;
                    }
                    else
                    {
                        Console.WriteLine("You must enter an X where there is not already a value");
                    }
                }

                // Put the value in the array
                aaBoard[iRowNum - 1, iColumnNum - 1] = 'O';

            }
        }
        
        //• Print the board one last time
        //• Show the winner
    }

    // Function to check integer input between 1 & 3
    public static int checkInteger(string sInput)
    {
        // Variables
        int iInput = 0;
        bool bContinue = false;

        // Check if it can convert to integer, if not inform user to input another number between 1 & 3
        while (bContinue == false)
        {
            try
            {
                // If you can convert & it is between 1 & 3, exit this loop
                iInput = int.Parse(sInput);
                if (iInput < 4 &&  iInput > 0)
                {
                    bContinue = true;
                }
                else
                {
                    // Get new input and leave bContinue as false
                    Console.WriteLine("You have entered a number less than 1 or greater than 3. Please try again");
                    sInput = Console.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine("Your number was not entered correctly. Please enter 1, 2, or 3");
                sInput = Console.ReadLine();
            }

        }

        return iInput;

    }
}
