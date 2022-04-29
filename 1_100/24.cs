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
    public ListNode SwapPairs(ListNode head) {
        ListNode temp = new ListNode(0);        
        temp.next = head;
        
        ListNode current = temp;
        
        while(current.next != null && current.next.next != null) {
            ListNode first_node = current.next;
            ListNode second_node = current.next.next;
            
            first_node.next = second_node.next;
            current.next = second_node;
            current.next.next = first_node;
            
            current = current.next.next;
        }
        
        return temp.next;
        
    }
}