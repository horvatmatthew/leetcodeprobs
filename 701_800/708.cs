/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
        next = null;
    }

    public Node(int _val, Node _next) {
        val = _val;
        next = _next;
    }
}
*/

public class Solution {
    public Node Insert(Node head, int insertVal) {
        Node newNode = new Node(insertVal);
        
        if(head == null) {           
            newNode.next = newNode;
            return newNode;
        }
        
        if(head.next == head) {
            head.next = newNode;
            newNode.next = head;
            return head;
        }
        
        Node current = head;
        while(current.next != head) {
            int currentVal = current.val;
            int nextVal = current.next.val;
            if(currentVal <= insertVal && nextVal >= insertVal) {
                break;
            } else if(currentVal > nextVal) {
                if(currentVal >= insertVal && nextVal >= insertVal) {
                    break;
                }
                if(currentVal <= insertVal && nextVal <= insertVal) {
                    break;
                }
            }
            current = current.next;
        }
        
        Node temp = current.next;
        current.next = newNode;
        newNode.next = temp;        
        
        return head;
    }
}