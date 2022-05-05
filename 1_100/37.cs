public class Solution {
    public void SolveSudoku(char[][] board)
    {
        canSolveFromCell(0, 0, board);              
    }
    
    public bool canSolveFromCell(int row, int col, char[][] board)
    {
        // If all the cells of row are done, increment the row
        if(col == board[row].Length)
        {
            col = 0;
            row++;
            
            // It means the whole board is traversed
            if(row == board.Length)
            {
                return true;
            }
        }
        
        // Skip entries already filled out. 
        if(board[row][col] != '.') 
        {
            return canSolveFromCell(row, col + 1, board);
        }
        
        // Check if value can be placed at index row, col        
        for(int val = 1; val <= 9; val++)
        {
            char c = (char)(val + '0');
            
            if(canPlaceVal(board, row, col, c)) 
            {
                board[row][col] = c;
                
                // Check for the next cell
                if(canSolveFromCell(row, col + 1, board)) 
                {
                    return true;
                }
                
                board[row][col] = '.';
            }
        }
        
        return false;
    }    
    
    private bool canPlaceVal(char[][] board, int row, int col, char charToPlace) 
    {
        // Check column of the placement
        foreach (char[] placementRow in board) 
        {
            if(charToPlace == placementRow[col])
            {
                return false;
            }
        }
        
        // Check row of the placement
        for (int i = 0; i < board[row].Length; i++)
        {
            if (charToPlace == board[row][i])
            {
                return false;
            }
        }
        
        // Check region constraints - get the size of the sub grid
        int regionSize = (int) Math.Sqrt(board.Length);
        
        int verticalBoxIndex = row / regionSize;
        int horizontalBoxIndex = col / regionSize;
        
        int topLeftOfSubBoxRow = regionSize * verticalBoxIndex;
        int topLeftOfSubBoxCol = regionSize * horizontalBoxIndex;
        
        for (int i = 0; i < regionSize; i++)
        {
            for (int j = 0; j < regionSize; j++) 
            {
                if (charToPlace == board[topLeftOfSubBoxRow + i][topLeftOfSubBoxCol + j])
                {
                    return false;
                }
            }
        }
        
        return true;
        
    }
}