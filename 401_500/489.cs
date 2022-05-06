/**
 * // This is the robot's control interface.
 * // You should not implement it, or speculate about its implementation
 * interface Robot {
 *     // Returns true if the cell in front is open and robot moves into the cell.
 *     // Returns false if the cell in front is blocked and robot stays in the current cell.
 *     public bool Move();
 *
 *     // Robot will stay in the same cell after calling turnLeft/turnRight.
 *     // Each turn will be 90 degrees.
 *     public void TurnLeft();
 *     public void TurnRight();
 *
 *     // Clean the current cell.
 *     public void Clean();
 * }
 */

/**
 * // This is the robot's control interface.
 * // You should not implement it, or speculate about its implementation
 * interface Robot {
 *     // Returns true if the cell in front is open and robot moves into the cell.
 *     // Returns false if the cell in front is blocked and robot stays in the current cell.
 *     public bool Move();
 *
 *     // Robot will stay in the same cell after calling turnLeft/turnRight.
 *     // Each turn will be 90 degrees.
 *     public void TurnLeft();
 *     public void TurnRight();
 *
 *     // Clean the current cell.
 *     public void Clean();
 * }
 */

class Solution {
    
    // direction array: up, right, down, left
    private int[,] dirs = new int[,]{{-1, 0}, {0, 1}, {1, 0}, {0, -1}};
    
    public void CleanRoom(Robot robot) {
        
        dfs(robot, 0, 0, 0, new HashSet<(int,int)>());
    }
    
    private void dfs(Robot robot, int row, int col, int currDir, HashSet<(int,int)> visited)
    {
        // clean the current cell, and mark it as visited
        robot.Clean();
        visited.Add((row, col));
        
        // explore 4 directions from current cell
        for(int d = 0; d < 4; d++)
        {   
            // next direction after making a right turn
            int nextDir = (currDir + d) % 4;
            
            // next cell to explore
            int nextRow = row + dirs[nextDir, 0];
            int nextCol = col + dirs[nextDir, 1];
            
            // if next cell is visitable, then move forward
            if(!visited.Contains((nextRow,nextCol)) && robot.Move())
            {
                dfs(robot, nextRow, nextCol, nextDir, visited);    
            }
          
            // make a right turn
            // the new direction will be calculated in the next round in the loop
            // eventually robot will face the same direction as the original direction when entering the current cell
            robot.TurnRight();
        }
        
        // backtrack to the previous cell, so robot can try a different direction.
        robot.TurnRight();
        robot.TurnRight();
        robot.Move();
        robot.TurnRight();
        robot.TurnRight(); 
    }
}