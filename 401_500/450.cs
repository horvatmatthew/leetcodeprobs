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
    public TreeNode DeleteNode(TreeNode root, int key) {
       TreeNode Cur = root;
        TreeNode Parent = null;
        bool IsLeftChild = false;
           
        while(Cur != null && Cur.val != key)
        {
             Parent = Cur;        
             if(Cur.val < key)
              {
                 Cur = Cur.right;
                 IsLeftChild = false;
             }
             else 
             {
                 Cur = Cur.left;
                 IsLeftChild = true;
             }
         }
        
        if(Cur != null)
        {
            if(Cur.left == null)
                Cur = Cur.right;
            else if(Cur.right == null)
                Cur = Cur.left;
            else
            {   
                TreeNode ToBeReplacedParent = null;
                TreeNode ToBeReplaced = Cur.right;
                    
                while(ToBeReplaced.left != null)
                {
                    ToBeReplacedParent = ToBeReplaced;
                    ToBeReplaced = ToBeReplaced.left;
                }
                
                Cur.val = ToBeReplaced.val;
                    
                if(ToBeReplacedParent == null)
                    Cur.right = Cur.right.right;
                else
                    ToBeReplacedParent.left = ToBeReplaced.right;
            }
            
            if(Parent != null)
            {
                if(IsLeftChild)
                    Parent.left = Cur;
                else
                    Parent.right = Cur;
            }
            else
            {
                root = Cur;
            }    
        }   
    
        return root;
     }
}