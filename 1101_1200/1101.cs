public class Solution {
    private int find(int i, int[] parents) {
        int root = i;
        while(parents[root] != -1) {
            root = parents[root];
        }
        
        return root;        
    }
    
    private bool union(int i, int j, int[] parents) {
        int iRoot = find(i, parents);
        int jRoot = find(j, parents);
        
        if(iRoot != jRoot) {
            parents[iRoot] = jRoot;
            return true;
        } else {
            return false;
        }
    }
    
    
    public int EarliestAcq(int[][] logs, int n) {
        int[] parents = new int[n];
        Array.Fill(parents, -1);
        
        Array.Sort(logs, (a,b) => a[0] - b[0]);
        
        foreach(var log in logs) {
            int root1 = find(log[1], parents);
            int root2 = find(log[2], parents);
            
            if(union(root1, root2, parents)) {
                n--;
                if(n == 1) {
                    return log[0];
                }
            }
        }
        
        return -1;
    }  
   
}