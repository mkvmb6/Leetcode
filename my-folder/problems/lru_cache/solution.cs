public class LRUCache {

    private int capacity;
    
    private Dictionary<int, LinkedListNode<(int key, int value)>> nodeMap;
    private LinkedList<(int key, int value)> ll;
    public LRUCache(int capacity) {
        this.capacity = capacity;
        nodeMap = new Dictionary<int, LinkedListNode<(int key, int value)>>();
        ll = new LinkedList<(int key, int value)>();
    }
    
    public int Get(int key) {
        if(nodeMap.ContainsKey(key)){
            var node = nodeMap[key];
            ll.Remove(node);
            ll.AddFirst(node);
            return node.Value.value;
        }
        return - 1;
    }
    
    public void Put(int key, int value) {
        if(nodeMap.ContainsKey(key)){
            var listNode = nodeMap[key];
            listNode.ValueRef.value = value;
            ll.Remove(listNode);
            ll.AddFirst(listNode);
        }
        else{
            if(nodeMap.Count == capacity){
                nodeMap.Remove(ll.Last.Value.key);
                ll.Remove(ll.Last);
            }
            ll.AddFirst((key, value));
            nodeMap[key] = ll.First;
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */