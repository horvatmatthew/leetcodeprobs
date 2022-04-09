    public class RowStrength
    {
        public int Row { get; set; }
        public int Count { get; set; }
    }

    public class MaxHeapInt32Comparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }

    public class MaxHeapRowComparer : IComparer<RowStrength>
    {
        public int Compare(RowStrength x, RowStrength y)
        {
            if (x.Count == y.Count)
            {
                return y.Row - x.Row;
            }
            else
            {
                return y.Count - x.Count;
            }
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
        public int[] KWeakestRows(int[][] mat, int k)
        {
            PriorityQueue<int, RowStrength> maxHeap = new PriorityQueue<int, RowStrength>(new MaxHeapRowComparer());

            for(int i = 0; i < mat.Length; i++)
            {
                int rowCount = 0;
                for(int j = 0; j < mat[i].Length;j++)
                {
                    if(mat[i][j] == 1)
                    {
                        rowCount++;
                    }
                }

                if(maxHeap.Count < k)
                {
                    maxHeap.Enqueue(i, new RowStrength { Row = i, Count = rowCount });
                } else
                {
                    maxHeap.TryPeek(out int element, out RowStrength priority);
                  
                    if(rowCount < priority.Count || (rowCount == priority.Count && i < element))
                    {
                        maxHeap.Dequeue();
                        maxHeap.Enqueue(i, new RowStrength{ Row = i, Count = rowCount });
                    }
                }
            }

            var returnList = maxHeap.UnorderedItems
                .OrderBy(x => x.Priority.Count)
                .ThenBy(x => x.Element)
                .Select(x => x.Element)
                .ToArray();
    

            return returnList;
        }
    }