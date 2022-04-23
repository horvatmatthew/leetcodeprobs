public class MinStack {
    int min=int.MaxValue;
    Stack<int> st=new Stack<int>();
    public MinStack() {
        
    }
    
    public void Push(int x) {
        if(x<=min)
        {
            st.Push(min);
            min=x;
        }
        st.Push(x);
    }
    
    public void Pop() {
        if(st.Pop()==min)
        {
            min=st.Pop();
        }
    }
    
    public int Top() {
        return st.Peek();
    }
    
    public int GetMin() {
        return min;
    }
}