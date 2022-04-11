/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
 public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            if(head == null)
            {
                return null!;
            }

            var slow = head;
            var fast = head;

            while (slow.next != null && fast.next != null && fast.next.next != null)
            {
                var temp = slow;
                
                slow = slow.next;
                fast = fast.next.next;

                if(slow == fast)
                {
                    return temp;
                }
            }

            return null!;
        }
    }