/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int start = 0;
        int end = Int32.MaxValue;
        
        while(true) {
            int mid = end - (end - start) / 2;
            var result = guess(mid);
            if(result == -1) {
                end = mid - 1;            
            } else if(result == 1) {
                start = mid + 1;
            } else {
                return mid;
            }
        }
    }
}