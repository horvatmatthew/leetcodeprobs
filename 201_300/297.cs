/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if (root == null) {
            return "X";
        }
        
        return root.val + "," +  serialize(root.left) + "," + serialize(root.right);
        
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        Queue<string> nodesLeft = new Queue<string>();
        foreach(var node in data.Split(",")) {
            nodesLeft.Enqueue(node);
        }
        
        return deserializeHelper(nodesLeft);
    }
    
    private TreeNode deserializeHelper(Queue<string> nodesLeft) {
        string value = nodesLeft.Dequeue();
        if(value.Equals("X")) {
            return null;
        }                   
        
        TreeNode newNode = new TreeNode(Int32.Parse(value));
        newNode.left = deserializeHelper(nodesLeft);
        newNode.right = deserializeHelper(nodesLeft);
        
        return newNode;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));