public class Solution {
    Dictionary<int, int> memo = new Dictionary<int, int>();
    
    public int Fib(int n) {
        if(n == 0) {
            return 0;
        }
        
        if(n == 1) {
            return 1;
        }
        
        if(memo.ContainsKey(n)) {
            return memo[n];
        } else {
            memo.Add(n, Fib(n-1) + Fib(n-2));
            return memo[n];
        }
    }
}