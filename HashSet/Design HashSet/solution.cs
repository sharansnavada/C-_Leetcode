public class MyHashSet {

    int[] hashTable;
    public MyHashSet() {
        hashTable = new int[10000000];
    }
    
    public void Add(int key) {
        hashTable[key] = 1;
    }
    
    public void Remove(int key) {
        hashTable[key] = 0;
    }
    
    public bool Contains(int key) {
        return hashTable[key] == 1;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
