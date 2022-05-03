public class Solution {
    public int SmallestDistancePair(int[] nums, int k) {
        Array.Sort(nums);
        
        int left = 0;
        int right = nums[nums.Length - 1] - nums[0];
        
        while(left < right){
            
            int mid = left + (right - left) / 2;
            
            if(MoreSmallPairThanMid(nums, mid, k)){
                right = mid;
            }
            else{
                left = mid+1;
            }
        }
        
        return left;
    }
    
    private bool MoreSmallPairThanMid(int[] nums, int mid, int k){
        int smallerpair = 0;
        int left = 0;
        
        for(int right = 1; right < nums.Length; right++){
            while(nums[right] - nums[left] > mid){
                left++;
            }
            
            smallerpair += right - left;
        }
        
        return smallerpair >= k;
    }
}