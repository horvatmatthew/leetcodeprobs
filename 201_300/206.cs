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
  public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if(head == null)
            {
                return null!;
            }

            if(head.next == null)
            {
                return head;
            }

            ListNode prev = null!;

            while(head != null)
            {
                ListNode ptr = head.next;
                head.next = prev;
                prev = head;
                head = ptr;                
            }

            return prev;            
        }
    }