public class StockPrice {

    SortedSet<(int price, int timestamp)> priceSorted;
    Dictionary<int, int> timeSorted;
    int maxTimeStamp = 0;
    public StockPrice() {
        priceSorted = new SortedSet<(int price, int timestamp)>();
        timeSorted = new Dictionary<int, int>();
        maxTimeStamp = 0;
    }
    
    public void Update(int timestamp, int price) {
        maxTimeStamp = Math.Max(maxTimeStamp, timestamp);
        if(timeSorted.ContainsKey(timestamp)){
            var oldPrice = timeSorted[timestamp];
            priceSorted.Remove((oldPrice, timestamp));
        }
        timeSorted[timestamp]= price;
        priceSorted.Add((price, timestamp));
    }
    
    public int Current() {
        return timeSorted[maxTimeStamp];
    }
    
    public int Maximum() {
        return priceSorted.Max.price;
    }
    
    public int Minimum() {
        return priceSorted.Min.price;
    }
}

/**
 * Your StockPrice object will be instantiated and called as such:
 * StockPrice obj = new StockPrice();
 * obj.Update(timestamp,price);
 * int param_2 = obj.Current();
 * int param_3 = obj.Maximum();
 * int param_4 = obj.Minimum();
 */