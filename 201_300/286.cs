public class Solution {
     public void WallsAndGates(int[][] rooms) {
        Queue<int[]> toVisit = new Queue<int[]>();
        for(int i = 0; i < rooms.Length;i++) {
            for(int j = 0; j < rooms[i].Length;j++) {
                if(rooms[i][j] == 0) {
                    toVisit.Enqueue(new [] {i, j});
                }
            }
        }
         
        while(toVisit.Any()) {
            int[] location = toVisit.Dequeue();
            int row = location[0];
            int col = location[1];
            UpdateRoom(row + 1, row , col, col, rooms, toVisit);
            UpdateRoom(row -1, row,  col, col, rooms, toVisit);
            UpdateRoom(row,row, col + 1,col, rooms, toVisit);
            UpdateRoom(row, row, col -1, col, rooms, toVisit);
        }
         

     }
    
     public void UpdateRoom(int i, int oldI, int j, int oldJ, int[][] rooms, Queue<int[]> toVisit) {
         if(i < 0 || j < 0 || i >= rooms.Length || j >= rooms[i].Length ||  rooms[i][j] != Int32.MaxValue) {
             return;
         }
         
         rooms[i][j] = rooms[oldI][oldJ] + 1;
         toVisit.Enqueue(new int[] { i, j});
     }
}
    