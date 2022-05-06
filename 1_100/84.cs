public class Solution {
    public int LargestRectangleArea(int[] heights) {
        if(heights.Length == 0) {
            return 0;
        }
        
        if(heights.Length == 1) {
            return heights[0];
        }
        
        int max = 0;
        Stack<int> stack = new Stack<int>();
        
        stack.Push(0);
        
        for(int i = 1; i < heights.Length;i++) {
            int curr = heights[i];
            if(curr >= heights[stack.Peek()]) {
                stack.Push(i);
            } else {
                while(stack.Any() && curr < heights[stack.Peek()]) {
                    int temp = heights[stack.Pop()];
                    if(stack.Count == 0) {
                        max = Math.Max(max, temp * i);
                    } else {
                        max = Math.Max(max, temp * (i - stack.Peek() -1));
                    }
                }
                stack.Push(i);
            }
        }
        
        if(stack.Any()) {
            int i = heights.Length;
            
            while(stack.Any()) {
                    int temp = heights[stack.Pop()];
                    if(stack.Count == 0) {
                        max = Math.Max(max, temp * i);
                    } else {
                        max = Math.Max(max, temp * (i - stack.Peek() -1));
                    }
            }   
        }
        
        return max;
    }
}