public class Solution {
    public double MyPow(double x, int n) {
        if(n == 0) {
            return 1;
        } 
        
        if(n == 1) {
            return x;
        }
        
        if(n == -1) {
            return 1/x;
        }
        
        var l = n / 2;
        var powL = MyPow(x,l);
        return powL * powL * MyPow(x, n-2 * l);
    }
}