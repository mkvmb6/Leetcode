public class SmallestInfiniteSet {

    PriorityQueue<int, int> pq;
    HashSet<int> set;

    public SmallestInfiniteSet() {
        set = new HashSet<int>();
        pq = new PriorityQueue<int,int>();
        for(int i=1;i<=1000;i++){
            AddBack(i);
        }
    }
    
    public int PopSmallest() {
        var num = pq.Dequeue();
        set.Remove(num);
        return num;
    }
    
    public void AddBack(int num) {
        if(set.Contains(num)){
            return;
        }
        set.Add(num);
        pq.Enqueue(num, num);
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */