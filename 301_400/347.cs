public class MinHeapInt32Comparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return x - y;
    }
}

public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
        {
            var minHeap = new PriorityQueue<int, int>(new MinHeapInt32Comparer());
            var frequencies = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(!frequencies.ContainsKey(nums[i]))
                {
                    frequencies.Add(nums[i], 0);
                }

                frequencies[nums[i]]++;
            }

            foreach (var key in frequencies.Keys)
            {
                if (minHeap.Count < k)
                {
                    minHeap.Enqueue(key, frequencies[key]);
                } else
                {
                    minHeap.TryPeek(out int minElement, out int minPriority);
                    if (minPriority < frequencies[key])
                    {
                        minHeap.Dequeue();
                        minHeap.Enqueue(key, frequencies[key]);
                    }
                }
            }

            var returnArray = new int[k];

            for (int j = 0; j < k; j++)
            {
                returnArray[j] = minHeap.Dequeue();
            }

            return returnArray;

        }        
}