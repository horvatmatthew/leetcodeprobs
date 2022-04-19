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
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> returnValues = new List<int>();
        Stack<TreeNode> nodesToVisit = new Stack<TreeNode>();
        
        if(root == null) {
            return returnValues;
        }
        
        TreeNode current = root;
        TreeNode prev = null;
        
        while(current != null || nodesToVisit.Any()) {
            while(current != null) {
                nodesToVisit.Push(current);
                current = current.left;
            }
            
            if(prev !=nodesToVisit.Peek().right && nodesToVisit.Peek().right != null) {
                current = nodesToVisit.Peek().right;
            } else {
                prev = nodesToVisit.Pop();
                returnValues.Add(prev.val);
            }
        }
        
        return returnValues;
    
    }
}