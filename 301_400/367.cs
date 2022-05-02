public class Solution {
    public bool IsPerfectSquare(int num) {
        if(num == 1) {
            return true;
        }
        long left = 2;
        long right = num;
        
        while (left <= right) {
            var mid = left + (right - left) / 2;
            if(mid * mid == num) {
                return true;
            } else if(mid * mid < num) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        
        return false;
    }
}