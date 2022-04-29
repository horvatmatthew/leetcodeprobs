public class Solution {
    public int KthGrammar(int n, int k) {
        if(n == 1 && k == 1) {
            return 0;
        }
       
        var newK = k % 2 == 0 ? k/2: k/2+1;
        var parent = KthGrammar(n-1, newK);
        
        if(parent == 0) {
            return k%2 == 0 ? 1: 0;
        } else {
            return k%2 == 0 ? 0 : 1;
        }
        
    }
}