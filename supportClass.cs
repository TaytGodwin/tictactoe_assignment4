namespace tictactoe_assignment4;

// player 1 is X player, player 2 is O 

public class supportClass
{
    
    // 1st Method Print The board
    public static void printBoard(char[,] aGameBoard)
    {
        //Print out a string 

        for (int i = 0; i < aGameBoard.GetLength(0); i++) // loops through Column
        {
            for (int j = 0; j < aGameBoard.GetLength(1); j++) // loops through Row
            {
                Console.Write(aGameBoard[i, j]); // Print either X or O 
                if (j != aGameBoard.GetLength(1) - 1) Console.Write(" | "); 
                //This puts in a line between each column
            }
            
            Console.WriteLine();
            if (i < aGameBoard.GetLength(0) - 1) Console.Write("----------");
            // This puts a line between each row 
            Console.WriteLine();
        }
       
        
    }
    
    
    public static (bool bResult, string sWinnerName) displayWinner(char[,] aGameBoard)
    {
        //Sets variables
        bool bResult = false;
        string sWinnerName = "";
       
        // Checks for row match
        for (int i = 0; i < aGameBoard.GetLength(0); i++) 
        {
            int j = 0;
            if (aGameBoard[i, j] == aGameBoard[i, j + 1] && aGameBoard[i, j + 1] == aGameBoard[i, j + 2] && aGameBoard[i, 0] != ' ' && aGameBoard[i, 1] != ' ' && aGameBoard[i, 2] != ' ')
            {
                bResult = true;
                sWinnerName = aGameBoard[i, j].ToString();
                break; 
            }
        }
        
        // Checks for Column match
        for (int j = 0; j < aGameBoard.GetLength(0); j++) 
        {
            int i = 0;
            if (aGameBoard[i, j] == aGameBoard[i + 1 , j] && aGameBoard[i + 1, j ] == aGameBoard[i + 2, j] && aGameBoard[0, j] != ' ' && aGameBoard[1, j] != ' ' && aGameBoard[2, j] != ' ')
            {
                bResult = true;
                sWinnerName = aGameBoard[i, j].ToString();
                break; 
            }
        } 
        
        // Check for column match \ this way
        if (aGameBoard[0, 0] == aGameBoard[1, 1] && aGameBoard[1, 1] == aGameBoard[2, 2] && aGameBoard[0, 0] != ' ' && aGameBoard[1, 1] != ' ' && aGameBoard[2, 2] != ' ')
        {
            //Changes to declare winner, and assigns winner to X or O 
            bResult = true;
            sWinnerName = aGameBoard[1, 1].ToString();
        }
        
        // Check for column match / this way
        else if (aGameBoard[0, 2] == aGameBoard[1, 1] && aGameBoard[1, 1] == aGameBoard[2, 0] && aGameBoard[0, 2] != ' ' && aGameBoard[1, 1] != ' ' && aGameBoard[2, 0] != ' ')
        {
            //Changes to declare winner, and assigns winner to X or O 
            bResult = true;
            sWinnerName = aGameBoard[1, 1].ToString();
        }
        
        // Returns array, first value as True or False, and second value as winner if winner exists. 
        return (bResult, sWinnerName);
    }
}