public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int left = 0;
        int right = letters.Length - 1;
        
        while(left <= right) {
            int mid = left + (right - left) / 2;
            
            if(letters[mid] <= target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        
        if(left >= letters.Length) {
            left = 0;
        }
        return letters[left];
        
    }
}