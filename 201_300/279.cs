public class Solution {
    public int NumSquares(int n) {
        var squareNumbers = new List<int>();
        for(int i = 1; i * i <= n;i++) {
            squareNumbers.Add(i*i);
        }
        
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(n);
        
        int level = 0;
        while(queue.Any()) {
            level++;
            Queue<int> nq = new Queue<int>();
            while(queue.Any()) {
                int rem = queue.Dequeue();
                foreach(int square in squareNumbers) {
                    if(rem == square) {
                     return level;
                    } else if(rem < square) {
                      break;
                    } else {
                     nq.Enqueue(rem - square);
                    }        
                }
            }        
            queue = nq;
        }
        
        return level;
    
    }
}