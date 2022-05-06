public class Solution {
    public List<string> LetterCombinations(string digits)
    {
        List<string> result = new List<string>();
        string[] mapping = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
    
        if (digits == null || digits.Length == 0)
        {
         return result;
        }
    
        letterCombinationsRecursive(result, digits, "", 0, mapping);
    
        return result;
    }
    
    public void letterCombinationsRecursive(List<string> result, string digits, string current, int index, string[] mapping)
    {
        if (index == digits.Length) {
           result.Add(current);
           return;
        }
        
        string letters = mapping[digits[index] - '0'];
        
        for(int i = 0; i < letters.Length; i++)
        {
           letterCombinationsRecursive(result, digits, current + letters[i], index + 1, mapping);     
        }
    }
    
}