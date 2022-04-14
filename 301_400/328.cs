**
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
    public ListNode OddEvenList(ListNode head) {
        if(head == null) return null;
    
        ListNode odd = head;
        ListNode current = head.next;
        ListNode even = current;
        
        while(current != null && current.next != null) {
            odd.next = current.next;
            odd = odd.next;
            current.next = odd.next;
            current = current.next;
        }
        
        odd.next = even;
        return head;
    }
}