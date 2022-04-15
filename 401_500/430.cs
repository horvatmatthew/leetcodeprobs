    public class Node
    {
        public int val;
        public Node prev;
        public Node next;
        public Node child;

        public Node(int val = 0, Node prev = null!, Node next = null!, Node child = null!)
        {
            this.val = val;
            this.prev = prev;
            this.next = next;
            this.child = child;
        }
    }


    public class Solution
    {
        public Node dfs(Node node)
        {
            Node pre = null;
            while (node != null)
            {
                pre = node;
                if (node.child != null)
                {
                    Node tail = dfs(node.child);
                    tail.next = node.next;
                    if (node.next != null)
                    {
                        node.next.prev = tail;
                    }


                    node.next = node.child;
                    node.child.prev = node;
                    node.child = null;

                    node = tail.next;
                    pre = tail;
                }
                else
                {
                    node = node.next;
                }
            }
            return pre;
        }





        public Node Flatten(Node head)
        {
            dfs(head);
            return head;
        }

    }