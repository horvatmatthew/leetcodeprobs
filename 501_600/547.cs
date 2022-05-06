public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        HashSet<int> visited = new HashSet<int>();
        
        int numberProvinces = 0;
        
        for(int city = 0; city < isConnected.Length; city++) 
        {
            if(visited.Contains(city))
            {
                continue;
            }    
            
            dfs(city, isConnected, visited);
            numberProvinces++;            
        }
        
        return numberProvinces;
    }
    
    private void dfs(int city, int[][] isConnected, HashSet<int> visited) 
    {
        if(visited.Contains(city)) 
        {
            return;
        }
        
        visited.Add(city);
        for(int anotherCity = 0; anotherCity < isConnected.Length; anotherCity++)
        {
            if(isConnected[city][anotherCity] == 0)
            {
                continue;
            }
            
            dfs(anotherCity, isConnected, visited);
        }
    }
}