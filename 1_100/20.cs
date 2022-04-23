public class Solution {
    public bool IsValid(string s) {
        if(s.Length == 1) {
            return false;
        }
        
        Stack<char> openParenStack = new Stack<char>();
        Dictionary<char, char> parens = new Dictionary<char, char>();
        
        parens.Add(')','(');
        parens.Add(']','[');
        parens.Add('}','{');
        
        for(int i = 0; i < s.Length;i++) {
            if(s[i] == '(' ||s[i] == '{' || s[i] == '[') {
                openParenStack.Push(s[i]);
            } else if(s[i] == ')' || s[i] == '}' || s[i] == ']') {
                if(openParenStack.Count == 0) {
                    return false;
                }
                var paren = openParenStack.Pop();
                if(paren != parens[s[i]]) {
                    return false;
                }
            }
        }
                   
        return openParenStack.Count == 0;
    }
}