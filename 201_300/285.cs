/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        if(root == null) {
            return null;
        }
        
        TreeNode cur = root;
        TreeNode prev = null;
        
        while(cur != null) {
            if(cur.val > p.val) {
                prev = cur;
                cur = cur.left;
            } else {
                cur = cur.right;
            }
        } 
        
        return prev;
    }
}