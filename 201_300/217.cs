public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> numbersSeen = new HashSet<int>();
        
        for(int i = 0; i < nums.Length; i++) {
            if(numbersSeen.Contains(nums[i])) {
                return true;
            } else {
                numbersSeen.Add(nums[i]);
            }
        }
        
        return false;
    }
}