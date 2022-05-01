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
    public TreeNode SortedArrayToBST(int[] nums) {
        if(nums == null || nums.Length == 0) {
            return null;                
        }
        
        return construct(nums, 0, nums.Length -1);
    }
    
    private TreeNode construct(int[] nums, int left, int right) {
        if(left > right) {
            return null;
        }
        
        int mid = left + (right - left) / 2;
        TreeNode current = new TreeNode(nums[mid]);
        current.left = construct(nums, left, mid-1);
        current.right = construct(nums, mid + 1, right);
        
        return current;
    }
}