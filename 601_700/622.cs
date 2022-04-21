public class MyCircularQueue {

	List<int> l = new List<int>();
	int k = 0;
	public MyCircularQueue(int k) {
		this.k = k;
	}

	public bool EnQueue(int value) {
		if(l.Count >= k) return false;
		l.Add(value);
		return true;
	}

	public bool DeQueue() {
		if(l.Count == 0) return false;
		l.RemoveAt(0);
		return true;
	}

	public int Front() {
		if(IsEmpty()) return -1;
		return l[0];
	}

	public int Rear() {
		if(IsEmpty()) return -1;
		return l[l.Count -1];
	}

	public bool IsEmpty() {
		return l.Count == 0;
	}

	public bool IsFull() {
		return l.Count == k;
	}
}
/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */