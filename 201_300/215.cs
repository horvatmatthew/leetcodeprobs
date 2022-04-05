public class MinHeapInt32Comparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return x - y;
    }
}

public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        var minHeap = new PriorityQueue<int, int>(new MinHeapInt32Comparer());

        for(int i = 0; i < nums.Length; i++)
        {
            if(minHeap.Count < k)
            {
                minHeap.Enqueue(nums[i], nums[i]);
            } else
            {
                var min = minHeap.Peek();
                if(nums[i] > min)
                {
                    minHeap.Dequeue();
                    minHeap.Enqueue(nums[i], nums[i]);
                }
            }
        }

        return minHeap.Dequeue();
    }
}