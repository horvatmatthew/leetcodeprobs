public class Solution {
public int FindTargetSumWays(int[] nums, int target) {
        int res = 0;
        Dfs(nums, target, 0, ref res);
        
        return res;
    }
    
    private void Dfs(int[] nums, int target, int idx, ref int count)
    {
        if(idx == nums.Length)
        {
            if( target == 0)
            {
                count++;
            }
            return;
        }
        
        Dfs(nums, target- nums[idx], idx+1, ref count);
        Dfs(nums, target+nums[idx], idx+1, ref count);
    }
}