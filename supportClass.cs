namespace tictactoe_assignment4;

// player 1 is X player, player 2 is O 

public class supportClass
{
    
    // 1st Method Print The board
    public void printBoard(char[,] aGameBoard)
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
            if (i != aGameBoard.GetLength(1) - 1) Console.Write("----------");
            // This puts a line between each row 
            
        }
    }
    
    //2nd Receives game board array as input and returns if there is a winner. 
    // Display winner if winner exists 
    public displayWinner(char[,] aGameBoard)
    {
        bool bResult = false;
        string sWinnerName = "";
        
        // if (Checks for rows)
        
        for (int i = 0; i < aGameBoard.GetLength(0); i++) // loops through rows
        {
            
            for (int j = 0; j < aGameBoard.GetLength(1); j++) // loops through columns
            {
                if (aGameBoard[0, 2] == aGameBoard[1, 2] && aGameBoard[1, 2] == aGameBoard[2, 2])
                {
                    
                }
                if (aGameBoard[i, j] == aGameBoard[i, j + 1] && aGameBoard[i, j + 1] == aGameBoard[i, j + 2])
                {
                    
                }
                
      
            }
        }
        
        
        aGameBoard[0, 2] == aGameBoard[1, 2] && aGameBoard[1, 2] == aGameBoard[2, 2];
        // Else if ( Checks for columns 
        
        //Else if (Checks for Diagonal \ ) 
        
        //Else if (Checks for other Diagonal /)  
        
        // else no winner yet returns false 
        
        // Returns array, first value as True or False, and second value as winner if winner exists. 
        return (bResult, sWinnerName);
    }
}