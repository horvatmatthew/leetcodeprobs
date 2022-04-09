   public class MaxHeapInt32Comparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }

   public class MinHeapInt32Comparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x - y;
        }
    }

       public class MedianFinder
    {

        PriorityQueue<int, int> minHeap;
        PriorityQueue<int, int> maxHeap;

        public MedianFinder()
        {
            minHeap = new PriorityQueue<int, int>(new MinHeapInt32Comparer());
            maxHeap = new PriorityQueue<int, int>(new MaxHeapInt32Comparer());
        }

        public void AddNum(int num)
        {
            maxHeap.Enqueue(num, num);
            var maxPop = maxHeap.Dequeue();
            minHeap.Enqueue(maxPop, maxPop);

            if(maxHeap.Count < minHeap.Count)
            {
                var minPop = minHeap.Dequeue();
                maxHeap.Enqueue(minPop, minPop);
            }
        }

        public double FindMedian()
        {
            return maxHeap.Count > minHeap.Count ? maxHeap.Peek() : ((double)maxHeap.Peek() + minHeap.Peek()) * 0.5;
        }
    }