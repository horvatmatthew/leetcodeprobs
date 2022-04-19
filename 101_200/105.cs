 public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
     }
  }

    public class Solution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            var n = preorder.Length;
            if (n == 0) return null;

            return DFS(preorder, 0, n - 1, inorder, 0, n - 1);
        }

        private TreeNode DFS(int[] preorder, int preLeft, int preRight, int[] inorder, int inLeft, int inRight)
        {
            if (preLeft > preRight) return null;

            var rootValue = preorder[preLeft];
            var rootInIndex = -1;

            for (int i = inLeft; i <= inRight; i++)
            {
                if (inorder[i] == rootValue)
                {
                    rootInIndex = i;
                    break;
                }
            }

            var count = rootInIndex - inLeft;

            var root = new TreeNode(rootValue);

            root.left = DFS(preorder, preLeft + 1, preLeft + count, inorder, inLeft, rootInIndex - 1);
            root.right = DFS(preorder, preLeft + count + 1, preRight, inorder, rootInIndex + 1, inRight);

            return root;
        }
    }