public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> seen = new HashSet<int>();
        
        while(n != 1) 
        {
            int current = n;
            int sum = 0;
            
            while (current != 0) {
                sum += ((current % 10) * (current % 10));
                current /= 10;                
            }
            
            if (seen.Contains(sum)) {
                return false;
            } 
            
            seen.Add(sum);
            n = sum;
        }
        
        return true;
    
    }
}