/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
      
        Node current = head;
        
        while(current != null) {
            Node newNode = new Node(current.val);
            Node tempNode = current.next;
            current.next = newNode;
            newNode.next = tempNode;
            current = tempNode;
        }
        
    
        current = head;
        
        while(current != null) {
          if(current.random != null) {
            current.next.random = current.random.next;   
          }
          current = current.next.next;
        }
        
        current = head;
        Node dummy = new Node(0);
        Node cloneTail = dummy;
        Node copy = null;
       
        while(current != null) {
            Node tempNode = current.next.next;
            tempNode = current.next.next;
            copy = current.next;
            cloneTail.next = copy;
            cloneTail = copy;
            
            current.next = tempNode;
            current = tempNode;
        }
        
        return dummy.next;
    }
}