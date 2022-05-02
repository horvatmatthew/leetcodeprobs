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
public class Solution {
     double minDiff = Double.MaxValue;
    int closest = 0;
    
    public int ClosestValue(TreeNode root, double target) {      
        
     BFS(root, target);
        
        return closest;
    }
    
    public void BFS(TreeNode root, double target) {
        if(root == null) {
            return;
        }
        
        var tempMin = (Math.Abs(root.val - target));
        if(tempMin < minDiff)
        {
            minDiff = tempMin;
            closest = root.val;
        }  
        
        BFS(root.left, target);
        BFS(root.right, target);
    }
}