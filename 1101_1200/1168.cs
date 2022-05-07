public class Solution {
    //use Kruskal' algorithm;
    //Mininum spanning tree problem;
    //for each vertex;
    //Make-Set
    //sort the edges into ascending order by weight w;
    //for each ege in this order;
    //      use union find to add the set to the result;
    //      union the edge if there are in different set;
    //how to represent the well build cost;
    //use 0 to i since there is no zero nodes;
    //use List<int[]> as our priority queue in c#;
    
    int[] sets;
    int[] rank;
    List<int[]> queue; //need to sort this queue by its weight;
    public int MinCostToSupplyWater(int n, int[] wells, int[][] pipes) {
        sets = new int[n+1];
        rank = new int[n+1];
        
        for(int i = 1; i <= n; i++)
        {
            sets[i] = i;
        }
        queue = new List<int[]>();
        //now lets add the edges into the queue;
        for(int i = 1; i <=n; i++)
        {
            queue.Add(new int[3]{0,i,wells[i-1]});
        }
        for(int i = 0; i <pipes.Length; i++)
        {
            queue.Add(new int[3]{pipes[i][0],pipes[i][1],pipes[i][2]});
        }        
        //sort the list by the weight in ascending order
        queue.Sort((a,b)=>a[2]-b[2]);
        int sum = 0;
        for(int i = 0;i<queue.Count;i++)
        {
            int[] w = queue[i];
            if (find(w[0])!=find(w[1]))
            {
                //add it to the result;
                sum += w[2];
                union(w[0],w[1]);
            }
        }
        return sum;
    }
    public int find(int x)
    {
        if(sets[x]==x)
            return x;
        else 
        {
            sets[x]= find(sets[x]);
        }
        return sets[x];
    }
    public void union(int x, int y)
    {
        int px = find(x);
        int py = find(y);
        if (px!=py)
        {
            if (rank[px]<=rank[py])
            {
                sets[px]=py;
                rank[py]++;
            }
            else
            {
                sets[py]=px;
                rank[px]++;
            }
        }
    }
    
    
}