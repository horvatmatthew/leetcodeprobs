public class MinIntervalComparer: IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return x[1] - y[1];
        }
    }

    public class Solution
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            PriorityQueue<int[], int[]> minHeap = new PriorityQueue<int[], int[]>(new MinIntervalComparer());

            Array.Sort(intervals, (a, b) => a[0] - b[0]);

            minHeap.Enqueue(intervals[0], intervals[0]);

            for(int i = 1; i < intervals.Length; i++)
            {
                var current = intervals[i];
                var earliest = minHeap.Dequeue();

                if(current[0] >= earliest[1])
                {
                    earliest[1] = current[1];
                } else
                {
                    minHeap.Enqueue(current, current);
                }

                minHeap.Enqueue(earliest, earliest);
            }

            return minHeap.Count;
        }
    }