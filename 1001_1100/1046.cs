public class MaxHeapInt32Comparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return y - x;
    }
}

public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var maxHeap = new PriorityQueue<int, int>(new MaxHeapInt32Comparer());

        for (int i = 0; i < stones.Length; i++)
        {
            maxHeap.Enqueue(stones[i], stones[i]);
        }

        for(int i = 0; i < stones.Length; i++) {

            if(maxHeap.Count > 1)
            {
                var stone1 = maxHeap.Dequeue();
                
                var stone2 = maxHeap.Dequeue();                   

                if(stone1 != stone2)
                {
                    var newWeight = stone1 - stone2;
                    maxHeap.Enqueue(newWeight, newWeight);
                }
            } 
        }

        if(maxHeap.Count == 0)
        {
            return 0;
        } else
        {
            return maxHeap.Dequeue();
        }
    }
}