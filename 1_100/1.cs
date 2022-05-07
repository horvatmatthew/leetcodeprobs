public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> possibles = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++) {
           var lookup = target - nums[i];
            
            if(possibles.ContainsKey(lookup)) {
                return new int[] { possibles[lookup], i};
            }
            
            if(!possibles.Keys.Contains(nums[i])) {
                possibles.Add(nums[i], i);
            } else {
                possibles[nums[i]] = i;
            }
        }
        
        return null;
    }
}