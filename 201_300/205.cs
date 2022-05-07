public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> mappings = new Dictionary<char, char>();
        HashSet<char> tMappings = new HashSet<char>();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(mappings.ContainsKey(s[i]))
            {
                if(mappings[s[i]] != t[i])
                {
                    return false;
                }
            } else
            {
              if(tMappings.Contains(t[i]))
              {
                  return false;
              }
                
              mappings.Add(s[i], t[i]);
              tMappings.Add(t[i]);
            }
        }
        
        return true;
    }                           
                          
}