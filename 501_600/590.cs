/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Postorder(Node root) {
        Stack<Node> stack = new Stack<Node>();
        List<int> output = new List<int>();
        
        if(root == null) {
            return output;
        }
        
        stack.Push(root);
        
        while(stack.Any()) {
            var node = stack.Pop();
            output.Insert(0, node.val);
            foreach(var child in node.children) {
                stack.Push(child);
            }
        }
        
        return output;
    }
}