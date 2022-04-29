public class Solution {
    public string DecodeString(string s) {
        Stack<int> counts = new Stack<int>();
        Stack<string> results = new Stack<string>();
        string res = string.Empty;
        int index = 0;
        
        while(index < s.Length) {
          if(Int32.TryParse(s[index].ToString(), out int value)) {
              int count = 0;
              while(Int32.TryParse(s[index].ToString(), out int parsedValue)) {
                  count = 10 * count + parsedValue;
                  index++;                  
              }
              counts.Push(count);
          } else if(s[index] == '[') {
              results.Push(res);
              res = string.Empty;
              index++;
          } else if(s[index] == ']') {
              StringBuilder sb = new StringBuilder(results.Pop());
              int count = counts.Pop();
              for(int i = 0; i < count; i++) {
                  sb.Append(res);
              }
              res = sb.ToString();
              index++;
          } else {
              res += s[index];
              index++;
          }
        }
        
        return res;
    }
}