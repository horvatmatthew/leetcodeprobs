public class MovingAverage {
    private Queue<int> items = new Queue<int>();
    private int sum = 0;
    private int size;
    
    public MovingAverage(int size) {
        this.size = size;
    }
    
    public double Next(int val) {
        sum += val;
        
        items.Enqueue(val);
        
        if(items.Count > size) {
            var removedItem = items.Dequeue();
            sum -= removedItem;
        }
        
        
        return sum/ (double)items.Count;
    }
}