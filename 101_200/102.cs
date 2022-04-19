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
    public IList<IList<int>> LevelOrder(TreeNode root) {
         IList<IList<int>> returnValues = new List<IList<int>>();
        
        if(root == null) {
            return returnValues;            
        }
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while(queue.Any()) {
            int size = queue.Count();
            List<int> current = new List<int>();
            
            for(int i = 0; i < size; i++) {
                TreeNode node = queue.Dequeue();
                current.Add(node.val);
                
                if(node.left != null) {
                    queue.Enqueue(node.left);
                }
                
                if(node.right != null) {
                    queue.Enqueue(node.right);
                }
            }
            
            returnValues.Add(current);
        }
        
        return returnValues;
    
    }
}