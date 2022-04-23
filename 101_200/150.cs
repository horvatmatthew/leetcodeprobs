public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> operands = new Stack<int>();
        
        for(int i = 0; i < tokens.Length; i++) {
            if(tokens[i] != "+" && tokens[i] != "-" && tokens[i] != "*" && tokens[i] != "/") {
                operands.Push(Int32.Parse(tokens[i]));
            } else {
                var first = operands.Pop();
                var second = operands.Pop();
                int result = 0;
                
                switch(tokens[i]) {
                    case "+":
                        result = first + second;
                        break;
                    case "-":
                        result = second - first;
                        break;
                    case "*":
                        result = first * second;
                        break;
                    case "/":
                        result = second / first;
                        break;
                    default:
                        result = 0;
                        break;
                }
                
                operands.Push(result);
            }
            
        }
        
        return operands.Pop();
    }
}