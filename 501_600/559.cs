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
  /*  public int MaxDepth(Node root) {
        if (root == null) {
            return 0;
        }
        
        int depth = 0;
        Queue<Node> queue = new Queue<Node>();
        
        queue.Enqueue(root);
        
        while(queue.Any()) {
            int size = queue.Count;
            
            for(int i = 0; i < size; i++) {
                var current = queue.Dequeue();
                foreach(var child in current.children) {
                    queue.Enqueue(child);
                }
            }
            
            depth++;
        }
        
        return depth;
    }*/
    
    private int maxDepth = 0;
    
    public int MaxDepth(Node root) {
        if(root == null) {
            return 0;
        }
        
        getMaxDepth(root, 1);
        return maxDepth;
    }
    
    public void getMaxDepth(Node node, int depth) {
        if(node == null) {
            return;
        }
        
        maxDepth = Math.Max(depth, maxDepth);
        
        foreach(var child in node.children) {
            getMaxDepth(child, depth + 1);
        }
    }
       
}