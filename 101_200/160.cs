 public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if(headA == null || headB == null) {
                return null;
            }
            
            ListNode ptr_a = headA;
            ListNode ptr_b = headB;

            while(ptr_a != ptr_b)
            {
                if(ptr_a == null)
                {
                    ptr_a = headB;
                } else {
                    ptr_a = ptr_a.next;
                }

                if(ptr_b == null)
                {
                    ptr_b = headA;
                } else {
                    ptr_b = ptr_b.next;
                }
            }

            return ptr_a;
        }
    }