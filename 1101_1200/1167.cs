   public class MinHeapInt32Comparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x - y;
        }
    }

    public class Solution
    {

        public int ConnectSticks(int[] sticks)
        {
            int cost = 0;

            if(sticks == null || sticks.Length <= 1)
            {
                return cost;
            }

            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>(new MinHeapInt32Comparer());

            for(int i = 0; i < sticks.Length; i++)
            {
                minHeap.Enqueue(sticks[i], sticks[i]);
            }

            while(minHeap.Count > 1)
            {
                int first = minHeap.Dequeue();
                int second = minHeap.Dequeue();

                cost += first + second;

                minHeap.Enqueue(first + second, first + second);
            }


            return cost;
        }
    }