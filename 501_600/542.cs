public class Solution {
    public int[][] UpdateMatrix(int[][] matrix) {
        if (matrix == null || matrix.Length == 0)
            return matrix;
        
        int[][] res = new int[matrix.Length][];
        Queue<int[]> q = new Queue<int[]>();
        int[] dx = new int[] { 0, 0, 1, -1 },
              dy = new int[] { 1, -1, 0, 0 };
        
        for (int i = 0; i < matrix.Length; i++)
            res[i] = Enumerable.Repeat(Int32.MaxValue, matrix[0].Length).ToArray();
        
        for (int i = 0; i < matrix.Length; i++)
            for (int j = 0; j < matrix[0].Length; j++)
                if (matrix[i][j] == 0)
                {
                    res[i][j] = 0;
                    q.Enqueue(new int[] { i, j });
                }
                    
        while (q.Count > 0)
        {
            int[] cur = q.Dequeue();
            
            for (int k = 0; k < 4; k++)
                if (cur[0] + dx[k] > -1 && cur[0] + dx[k] < res.Length && cur[1] + dy[k] > -1 && cur[1] + dy[k] < res[0].Length && res[cur[0] + dx[k]][cur[1] + dy[k]] > res[cur[0]][cur[1]] + 1)
                {
                    res[cur[0] + dx[k]][cur[1] + dy[k]] = res[cur[0]][cur[1]] + 1;
                    q.Enqueue(new int[] { cur[0] + dx[k], cur[1] + dy[k] });
                }
        }
                    
        return res;
    }
}