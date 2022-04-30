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
public class BSTIterator {
    Stack<TreeNode> items = new Stack<TreeNode>();
    
    
    public BSTIterator(TreeNode root) {
        while (root != null)  {
            items.Push(root);
            root = root.left;
        }
        
    }
    
    public int Next() {
        var returnItem = items.Pop();
        if(returnItem.right != null) {
            TreeNode current = returnItem.right;    
            while(current != null) {
                items.Push(current);
                current = current.left;           
            }            
            
        }       
        
        return returnItem.val;
    }
    
    public bool HasNext() {
        return items.Any();
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */