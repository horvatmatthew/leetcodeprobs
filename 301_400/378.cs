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

    public class Solution
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(new MaxHeapInt32Comparer());

            for(int i = 0; i < matrix.Length;i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    if(maxHeap.Count < k)
                    {
                        maxHeap.Enqueue(matrix[i][j], matrix[i][j]);
                    } else
                    {
                        var element = maxHeap.Peek();
                        if(element > matrix[i][j])
                        {
                            maxHeap.Dequeue();
                            maxHeap.Enqueue(matrix[i][j], matrix[i][j]);
                        }
                    }
                }
            }

            return maxHeap.Peek();
        }
    }
