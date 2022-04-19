/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if(k == 0 || head == null || head.next == null) {
            return head;
        }
        
        ListNode current = head;
        int length = 0;
        
        while(current != null) {
            current = current.next;
            length++;
        }
        
        int newHead = length - k % length;
        
        if(newHead == length) {
            return head;
        }
        
        ListNode tail = head;                
       
        // find new tail
        for(int i = 0; i < newHead - 1; i++) {
            tail = tail.next;
        }
        
        // find new head
        ListNode newHeadNode = tail.next;
        
        // find tail of existing linked list
        current = newHeadNode;
        while(current.next != null) {
            current = current.next;
        }
        
        // point old tail to new head
        current.next = head;
        // point new tail to null
        tail.next = null;
        
        return newHeadNode;
    }
}