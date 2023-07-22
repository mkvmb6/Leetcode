public class RecentCounter {
    LinkedList<int> pingWindow;

    public RecentCounter() {
        pingWindow = new LinkedList<int>();
    }
    
    public int Ping(int t) {
        pingWindow.AddLast(t);
        var diff = t - 3000;
        while(pingWindow.First.Value < diff){
            pingWindow.RemoveFirst();
        }
        return pingWindow.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */