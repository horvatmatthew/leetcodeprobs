   public class MinHeapInt32Comparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x - y;
        }
    }

    public class Solution
    {

  public int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>(new MinHeapInt32Comparer());

            for(int i = 0; i < heights.Length-1; i++)
            {
                var difference = heights[i + 1] - heights[i];

                if(difference < 0)
                {
                    continue;
                }

                if(minHeap.Count < ladders)
                {
                    minHeap.Enqueue(difference, difference);
                } else
                {
                    if (minHeap.Count > 0)
                    {
                        var min = minHeap.Peek();
                        if (difference > min)
                        {
                            minHeap.Dequeue();
                            minHeap.Enqueue(difference, difference);
                            bricks -= min;
                        }
                        else
                        {
                            bricks -= difference;
                        }                    
                     } else
                    {
                        bricks -= difference;
                    }

                    if(bricks < 0)
                    {
                        return i;
                    }
                }


            }

            return heights.Length - 1;
        }
    
    }