public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) {
          val = x;
          next = null!;
     }
  }



    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;

            while(fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            fast = head;
            slow = Reverse(slow);

            while(slow != null)
            {
                if(fast.val != slow.val)
                {
                    return false;
                }

                fast = fast.next;
                slow = slow.next;
            }

            return true;
        }

        public ListNode Reverse(ListNode node)
        {
            ListNode prev = null!;
            ListNode next = null!;
            ListNode curr = node;

            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }
    }