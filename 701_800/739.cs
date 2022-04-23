public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] daysToWait = new int[temperatures.Length];
        Stack<int> stack = new Stack<int>();
        
        for(int i = 0; i < temperatures.Length;++i) {
            while(stack.Any() && temperatures[stack.Peek()] < temperatures[i]) {
                daysToWait[stack.Peek()] = i - stack.Peek();
                stack.Pop();
            }
            stack.Push(i);
        }       
        
        
        return daysToWait;
    }
}