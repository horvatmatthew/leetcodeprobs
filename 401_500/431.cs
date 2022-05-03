public class Codec {

    // Encodes an n-ary tree to a binary tree.
    public TreeNode encode(Node root) {
        return DFS(root);
    }

    private TreeNode DFS(Node root) {
        if (root == null) return null;
        var n = root.children.Count;

        var result = new TreeNode(root.val);

        if (n > 0) result.left = DFS(root.children[0]);

        TreeNode curRight = result.left;
        for (int i = 1; i < n; i++) {
            curRight.right = DFS(root.children[i]);
            curRight = curRight.right;
        }

        return result;
    }

    // Decodes your binary tree to an n-ary tree.
    public Node decode(TreeNode root) {
        return DFS(root);
    }

    private Node DFS(TreeNode root) {
        if (root == null) return null;

        var children = new List<Node>();
        var result = new Node(root.val, children);

        var cur = root.left;
        while (cur != null) {
            children.Add(DFS(cur));
            cur = cur.right;
        }

        return result;
    }
}
