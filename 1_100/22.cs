public class Solution {
    
    public IList<string> GenerateParenthesis(int n) {
        HashSet<string> allCombos = new HashSet<string>();
        
        for(int i = 0; i < n; i++) {
            if(allCombos.Count == 0) { // Initial
                allCombos.Add("()");                
            } else {
                HashSet<string> combos = new HashSet<string>();
                foreach(var combo in allCombos) {
                    
                    // Add parenthesis to both sides
                    combos.Add(combo+"()");
                    combos.Add("()"+combo);
                    
                    // Add parenthesis inside openings
                    for(int j = 0; j < combo.Length - 1; j++) {
                        if(combo[j] == '(' && combo[j+1] == ')') {  // Opening detected
                            combos.Add(combo.Substring(0, j+1) + "()" + combo.Substring(j+1));
                            combos.Add(combo.Substring(0, j+1) + ")(" + combo.Substring(j+1));                            
                        }
                    }
                }
                
                allCombos = combos;
            }
        }
        
        return new List<string>(allCombos);
    }
}