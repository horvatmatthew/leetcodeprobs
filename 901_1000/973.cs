 public static class Util
    {
        public static int GetDistance(int[] item)
        {
            return (item[0] * item[0] + item[1] * item[1]);
        }

    }

    public class MaxPointComparer: IComparer<int[]>
  {

        public int Compare(int[] x, int[] y)
        {
            return Util.GetDistance(y) - Util.GetDistance(x);
        }
   }

    public class Solution
    {

        public int[][] KClosest(int[][] points, int k)
        {
            PriorityQueue<int[], int[]> maxHeap = new PriorityQueue<int[], int[]>(new MaxPointComparer());
            int[][] returnArray = new int[k][];

            for(int i = 0; i < points.Length; i++)
            {
                maxHeap.Enqueue(points[i], points[i]);
                if(maxHeap.Count > k)
                {
                    maxHeap.Dequeue();
                }
            }

            int j = 0;
            foreach (var item in maxHeap.UnorderedItems)
            {
                returnArray[j] = item.Element;
                j++;
            }

            return returnArray;
        }
    }