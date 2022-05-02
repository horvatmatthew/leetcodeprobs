public class Solution {
    public int[] SearchRange(int[] nums, int target) {
     int[] result = new int[2];
     result[0] = findStartingIndex(nums, target);
     result[1] = findEndingIndex(nums, target);
        
     return result;
    }
    
    
    public int findStartingIndex(int[] nums, int target) {
        int index = -1;
        
        int start = 0;
        int end = nums.Length - 1;
        
        while (start <= end) {
            int midpoint = start + (end - start) / 2;
            
            if(nums[midpoint] >= target) {
                end = midpoint - 1;
            } else {
                start = midpoint + 1;
            }
            
            if(nums[midpoint] == target) {
                index = midpoint;
            }
        }
        
        return index;
    }
    
    public int findEndingIndex(int[] nums, int target) {
        int index = -1;
        
                
        int start = 0;
        int end = nums.Length - 1;
        
        while (start <= end) {
            int midpoint = start + (end - start) / 2;
            
            if(nums[midpoint] <= target) {
                start = midpoint + 1;
            } else {
                end = midpoint - 1;
            }
            
            if(nums[midpoint] == target) {
                index = midpoint;
            }
        }
        
        return index;
    }
}