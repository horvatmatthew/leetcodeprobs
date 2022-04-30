public class Solution {    
    bool[] rows;
    bool[] cols;
    bool[] tiltl; // top-left to bottom-right
    bool[] tiltr; // top-right to bottom-left;
        
    public int TotalNQueens(int n) {
            rows = new bool[n];
            cols = new bool[n];
            tiltl = new bool[n * 2 -1];
            tiltr = new bool[n * 2 - 1];
            
            return Travel(n, 0);
    }
    
    private int Travel(int n, int y) {
        if(y == n) {
            return 1;
        }
        
        int ret = 0;
        for(int x = 0; x < n; x++) {
            if(rows[y] || cols[x] || tiltl[x-y + n-1] || tiltr[x+y]) {
                continue;
            }
            
            rows[y] = true;
            cols[x] = true;
            tiltl[x - y + n - 1] = true;
            tiltr[x + y] = true;
            ret += Travel(n, y + 1);
            rows[y] = false;
            cols[x] = false;
            tiltl[x - y + n - 1] = false;
            tiltr[x + y] = false;
        }
        
        return ret;
    }
}