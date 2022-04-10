    public class Node
    {
        public int value;
        public Node next;
    }

    public class MyLinkedList
    {

        private Node tail = null!;
        private Node head = null!;
        private int length = 0;

        public MyLinkedList()
        {
        }

        public int Get(int index)
        {
            if (index < 0 || index >= length)
            {
                return -1;
            }

            int i = 0;
            var curr = head;
            while (i != index)
            {
                i++;
                curr = curr.next;
            }

            return curr.value;
        }

        public void AddAtHead(int val)
        {
            var tempHead = new Node();
            tempHead.value = val;
            tempHead.next = head;
            head = tempHead;
            if (tail == null)
            {
                tail = tempHead;
            }

            length++;
        }

        public void AddAtTail(int val)
        {
            if (tail == null)
            {
                AddAtHead(val);
                return;
            }

            var tempTail = new Node();
            tempTail.value = val;
            tail.next = tempTail;
            tail = tail.next;
            length++;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index == length)
            {
                AddAtTail(val);
                return;
            }

            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            if (index < 0 || index > length)
            {
                return;
            }

            index--;
            int i = 0;
            var curr = head;
            while (i != index)
            {
                i++;
                curr = curr.next;
            }

            var next = curr.next;
            var tempNode = new Node();
            tempNode.value = val;
            curr.next = tempNode;
            curr.next.next = next;
            length++;
        }

        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= length)
            {
                return;
            }

            if (index == 0)
            {
                head = head.next;
                if (length == 1)
                {
                    tail = null!;
                }
            }
            else
            {
                index--;
                int i = 0;
                var curr = head;
                while(i != index)
                {
                    i++;
                    curr = curr.next;
                }

                var itemToRemove = curr.next;
                curr.next = itemToRemove.next;
                if (itemToRemove == tail)
                {
                    tail = curr;
                }
            }

            length--;
        }
    }