/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int low = 1;
        int high = n;
        
        while(low <= high) {
            int mid = low + (high - low) / 2;
            
            if(IsBadVersion(mid)) {
                high = mid -1;               
            } else {
                low = mid +1;                
            }
        }
        
        return low;
    }
}