/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;

    public Node() {}

    public Node(int _val) {
        val = _val;
        left = null;
        right = null;
    }

    public Node(int _val,Node _left,Node _right) {
        val = _val;
        left = _left;
        right = _right;
    }
}
*/

public class Solution {
    Node head = null;
    Node prev = null;

    
    public Node TreeToDoublyList(Node root) {
        dfs(root);
        if (head == null) {
            return null;
        }
        head.left = prev;
        prev.right = head;
        return head;
    }
    
    private void dfs(Node root) {
        if (root == null) {
            return;
        }
        
        dfs(root.left);
        
        if(head == null) {
            head = root;
        } else {
            prev.right = root;
            root.left = prev;
        }
        prev = root;
        
        dfs(root.right);
    }
}