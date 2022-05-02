public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        
        while(left + 1 < right) {
            int mid = left + (right - left)  / 2;
            if(nums[mid] > nums[right]) {
                left++;
            } else {
                right--;
            }
        }
        
        return Math.Min(nums[left], nums[right]);
    }
}