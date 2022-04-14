public class Solution {

    Dictionary<int, List<int>> indexes;
    
    public Solution(int[] nums) {
        indexes = new Dictionary<int, List<int>>();
        
        for(int i = 0; i < nums.Length;i++) {
            if(!indexes.ContainsKey(nums[i])) {
                indexes.Add(nums[i], new List<int>());
            }
            
            indexes[nums[i]].Add(i);
        }
    }
    
    public int Pick(int target) {
        Random rnd = new Random();
        var count =  indexes[target].Count;
        var random = rnd.Next(0,count);
        
        return indexes[target][random];
        
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */