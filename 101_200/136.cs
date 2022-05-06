public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> singles = new HashSet<int>();
        
        for(int i = 0; i < nums.Length; i++) {
            if(singles.Contains(nums[i])) {
                singles.Remove(nums[i]);
            } else {
                singles.Add(nums[i]);
            }
        }
        
        return singles.ElementAt(0);
    }
}