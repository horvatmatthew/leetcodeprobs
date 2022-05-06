public class MyHashSet {
    private int keyRange = 769;
    private List<int>[] buckets = null;
    
    public MyHashSet() {
        buckets = new List<int>[keyRange];
    }
    
    public void Add(int key) {
        if (Contains(key))
            return;
        
        int slot = key % keyRange;
        
        if (buckets[slot] == null)
            buckets[slot] = new List<int>();
        
        buckets[slot].Add(key);
    }
    
    public void Remove(int key) {
        if (!Contains(key))
            return;
        
        int slot = key % keyRange;
        
        if (buckets[slot] == null)
            return;
        
        for (int i = 0; i < buckets[slot].Count; i++)
            if (buckets[slot][i] == key)
            {
                buckets[slot].RemoveAt(i);
                return;
            }
    }
    
    public bool Contains(int key) {
        int slot = key % keyRange;
        
        if (buckets[slot] == null)
            return false;
        
        for (int i = 0; i < buckets[slot].Count; i++)
            if (buckets[slot][i] == key)
                return true;
        
        return false;
    }
}