/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution 
{
    public IList<TreeNode> GenerateTrees(int n) 
    {
        var memo = new Dictionary<(int, int), List<TreeNode>>();
        
        return Helper(1, n, memo);
    }
    
    private List<TreeNode> Helper(int start, int end, Dictionary<(int, int), List<TreeNode>> memo)
    {
        if (memo.ContainsKey((start, end)))
        {
            return memo[(start, end)];
        }
        
        var treeLists = new List<TreeNode>();
        
        //base case #1 -> tree of size 0
        //NOTE: we need to add null to the list because
        //      we need a value to correctly execute the foreach loops
        //      even when one of the lists has no valid trees
        if (start > end)
        {
            treeLists.Add(null);
        }
        //base case #2 -> tree of size 1
        else if (start == end)
        {
            treeLists.Add(new TreeNode(start));
        }
        else
        {
            for (int i = start; i <= end; i++)
            {
                var leftSubTrees = Helper(start, i - 1, memo);
                var rightSubTrees = Helper(i + 1, end, memo);
                
                foreach (TreeNode lst in leftSubTrees)
                {
                    foreach (TreeNode rst in rightSubTrees)
                    {
                        treeLists.Add(new TreeNode(i, lst, rst));
                    }                    
                }
            }
        }
        
        memo.Add((start, end), treeLists);
        
        return treeLists;
    }
}