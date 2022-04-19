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
    public int CountUnivalSubtrees(TreeNode root) {
        int[] counter = new int[1];
        
        dfs(root, counter);
        
        return counter[0];
    }
    
    public void dfs(TreeNode root, int[] counter) {
        if(root == null) {
            return;
        }
        
        if(univalued(root, root.val)) {
            counter[0]++;
        }
        
        dfs(root.left, counter);
        dfs(root.right, counter);
    }
    
    public bool univalued(TreeNode root, int value) {
        if(root == null) {
            return true;
        }
        
        if(root.val != value) {
            return false;
        }
        
        return univalued(root.left, value) && univalued(root.right, value);
    }
}