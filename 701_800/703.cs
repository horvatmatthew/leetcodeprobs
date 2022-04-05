 public class MinHeapInt32Comparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x - y;
        }
    }

    public class KthLargest
    {

        private PriorityQueue<int, int> minHeap;
        private int maxSize;

        public KthLargest(int k, int[] nums)
        {
            minHeap = new PriorityQueue<int, int>(new MinHeapInt32Comparer());
            maxSize = k;
            for(int i = 0; i < nums.Length; i++)
            {
                if(minHeap.Count < maxSize)
                {
                    minHeap.Enqueue(nums[i], nums[i]);
                } else
                {
                    if(nums[i] > minHeap.Peek())
                    {
                        minHeap.Dequeue();
                        minHeap.Enqueue(nums[i], nums[i]);
                    }
                }
            }
        }

        public int Add(int val)
        {
            if (minHeap.Count < maxSize)
            {
                minHeap.Enqueue(val, val);
            }
            else
            {
                if (val > minHeap.Peek())
                {
                    minHeap.Dequeue();
                    minHeap.Enqueue(val, val);
                }
            }

            return minHeap.Peek();
        }
    }