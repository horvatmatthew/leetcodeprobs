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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> returnValues = new List<int>();
        
        if(root == null) {
            return returnValues;
        }        

        Stack<TreeNode> nodesToVisit = new Stack<TreeNode>();
        nodesToVisit.Push(root);
        
        while(nodesToVisit.Any()) {
            var item = nodesToVisit.Pop();
            
            returnValues.Add(item.val);
            
            if(item.right != null) {
                nodesToVisit.Push(item.right);            
            }
            
            if(item.left != null) {
                nodesToVisit.Push(item.left);
            }
        }
        
        return returnValues;
    }
}