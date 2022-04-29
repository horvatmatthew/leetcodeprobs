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
    public bool IsValid(TreeNode root, TreeNode lowVal, TreeNode highVal) {
        if (root == null) {
            return true;
        }
        
        if((lowVal != null && root.val <= lowVal.val) || (highVal != null && root.val >= highVal.val)) {
            return false;
        }
        
        return IsValid(root.right, root, highVal) && IsValid(root.left, lowVal, root);
    }
    public bool IsValidBST(TreeNode root) {
        return IsValid(root, null, null);
    }
}