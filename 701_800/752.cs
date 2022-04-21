public class Solution {
    public int OpenLock(string[] deadends, string target) {
        HashSet<string> dead_ends = new HashSet<string>();
        HashSet<string> visited = new HashSet<string>();
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("0000");
        
        visited.Add("0000");
        
        for(int i = 0;i < deadends.Length;i++) {
            dead_ends.Add(deadends[i]);           
        }
        
        int level = 0;
        while(queue.Any()) {
            int size = queue.Count;
            while(size > 0) {
                var lock_position = queue.Dequeue();
                if(dead_ends.Contains(lock_position)) {
                    size--;
                    continue;
                }
                
                if(lock_position == target) {
                    return level;
                }
                
                StringBuilder sb = new StringBuilder(lock_position);
                for(int i = 0; i < 4; i++) {
                    char current_position = sb[i];
                    string s1 = sb.ToString().Substring(0,i) + (current_position == '9' ? 0 : current_position - '0' + 1) + sb.ToString().Substring(i+1);
                    string s2 = sb.ToString().Substring(0,i) + (current_position == '0' ? 9 : current_position - '0' - 1) + sb.ToString().Substring(i+1);
                    
                    if(!visited.Contains(s1) && !dead_ends.Contains(s1)) {
                        queue.Enqueue(s1);
                        visited.Add(s1);
                    }
                    
                    if(!visited.Contains(s2) && !dead_ends.Contains(s2)) {
                        queue.Enqueue(s2);
                        visited.Add(s2);
                    }

                }
                
                size--;
            }
            level++;
        }
        
        return -1;
    }
}