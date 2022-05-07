public class Solution {
    public int CountComponents(int n, int[][] edges) {
        int[] ids = new int[n];
        HashSet<int> set = new HashSet<int>();
        
        for(int i = 0; i < ids.Length;i++) 
        {
            ids[i] = i;
        }
        
        foreach(var edge in edges) {
            union(edge[0], edge[1], ids);
        }
        
        for(int i = 0; i < ids.Length;i++) {
            set.Add(find(i, ids));
        }
        
        return set.Count;
        
    }
    
    private void union(int edge1, int edge2, int[] ids) {
        int parent1 = find(edge1, ids);
        int parent2 = find(edge2, ids);
        
        ids[parent1] = parent2;
    }
    
    private int find(int edge, int[] ids) {
        if(ids[edge] != edge) {
            ids[edge] = find(ids[edge], ids);
        }
        
        return ids[edge];
    }
        
}