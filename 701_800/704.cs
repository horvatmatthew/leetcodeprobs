public class Solution {
    public int Search(int[] nums, int target) {
        int start = 0;
        int end = nums.Length -1;
        
        if(nums.Length == 0) {
            return -1;
        }
        
        if(nums[start] == target) {
            return 0;
        }
        
        if(nums[end] == target) {
            return end;
        }
        
        int middle = (start+end)/2;
        
        while(start <= end) {
            if(nums[middle] < target) {
                start = middle+1;
                middle = (start+end)/2;
            } else if(nums[middle] > target) {
                end = middle-1;
                middle = (start+end)/2;                
            } else {
                return middle;
            }
            
            
        }
        
        return -1;
        
    }
}