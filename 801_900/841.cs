public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        HashSet<int> visited = new HashSet<int>();
        visited.Add(0);
        
        Stack<int> stack = new Stack<int>();
        stack.Push(0);
        
        while(stack.Any()) {
            var keys = rooms[stack.Pop()];
            
            foreach(int key in keys) {
                if(!visited.Contains(key)) {
                    visited.Add(key);
                    stack.Push(key);
                }
            }
        }
        
        return visited.Count == rooms.Count;
    }
}