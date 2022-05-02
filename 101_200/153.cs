public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length -1;
        
        while(left < right) {
            int mid = left + (right - left) / 2;
            if(mid > 0 && nums[mid] < nums[mid-1]) {
                return nums[mid];
            } else if(nums[left] <= nums[mid] && nums[mid] > nums[right]) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        
        return nums[left];
    }
}