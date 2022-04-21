public class Solution {
    public int NumIslands(char[][] grid) {
        if(grid.Length == 0 || grid[0].Length == 0) {
            return 0;
        }
        
        int numberIslands = 0;
        
        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[i].Length; j++) {
                if(grid[i][j] == '1') {
                    numberIslands += bfs(grid, i, j);
                }
            }
        }
        
        return numberIslands;
    }
    
    public int bfs(char[][] grid, int i, int j) { 
      if(i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] == '0') {
          return 0;
      }
        
       grid[i][j] = '0';
        bfs(grid, i + 1, j);
        bfs(grid, i - 1, j);
        bfs(grid, i, j + 1);
        bfs(grid, i, j - 1);
       
        return 1;
    }
}