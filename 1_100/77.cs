public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        IList<IList<int>> ans = new List<IList<int>>();
        
        if(k == 0) {
            ans.Add(new List<int>());
            return ans;
        }
        
        backtrack(1, new List<int>(), n, k, ans);
        return ans;
    }
    
    public void backtrack(int start, List<int> current, int n, int k, IList<IList<int>> ans) {
        if(current.Count == k) {
            ans.Add(new List<int>(current));
        }
        
        for(int i = start; i <= n && current.Count < k; i++) {
            current.Add(i);
            backtrack(i+1, current, n, k, ans);
            current.RemoveAt(current.Count -1);
        }
    }
}