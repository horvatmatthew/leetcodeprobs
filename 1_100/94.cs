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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> returnValues = new List<int>();
        
        if(root == null) {
            return returnValues;
        }        

        Stack<TreeNode> nodesToVisit = new Stack<TreeNode>();
        TreeNode current = root;
        
        while(current != null || nodesToVisit.Any()) {
            while(current != null) {
                nodesToVisit.Push(current);
                current = current.left;
            }
            
            current = nodesToVisit.Pop();
            returnValues.Add(current.val);
            
            current = current.right;
        }
        

        
        return returnValues;
    }
}