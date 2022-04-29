public class MyStack {
    Queue<int> q = null;
    
    public MyStack() {
        q = new Queue<int>();
    }
    
    public void Push(int x) {
        q.Enqueue(x);
    }
    
    public int Pop() {
        if (Empty())
            return Int32.MinValue;
        
        Queue<int> cur = new Queue<int>();
        
        while (q.Count > 1)
            cur.Enqueue(q.Dequeue());
        
        int top = q.Dequeue();
        
        q = cur;
        
        return top;
    }
    
    public int Top() {
        if (Empty())
            return Int32.MinValue;
        
        Queue<int> cur = new Queue<int>();
        
        while (q.Count > 1)
            cur.Enqueue(q.Dequeue());
        
        int top = q.Dequeue();
        
        cur.Enqueue(top);
        q = cur;
        
        return top;
    }
    
    public bool Empty() {
        return q.Count == 0;
    }
}
/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */