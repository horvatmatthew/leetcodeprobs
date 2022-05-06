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
    public bool IsSameTree(TreeNode p, TreeNode q) {
       Queue<TreeNode> leftTree = new Queue<TreeNode>();
       Queue<TreeNode> rightTree = new Queue<TreeNode>();
        
       leftTree.Enqueue(p);
       rightTree.Enqueue(q);
        
       while(leftTree.Any() && rightTree.Any()) {
           var left = leftTree.Dequeue();
           var right = rightTree.Dequeue();
           
           if(left == null && right == null) {
               continue;
           }
           
           if(left == null || right == null) {
               return false;
           }
            
           if(left.val != right.val) {
               return false;
           }
           
          
           leftTree.Enqueue(left.left);
           leftTree.Enqueue(left.right);
           rightTree.Enqueue(right.left);
           rightTree.Enqueue(right.right);
       }
        
        
       return true;
    }
}