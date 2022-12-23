public class Solution {
    public int MaxProfit(int[] prices) {
        var cache = new Dictionary<(int, int), int>();
        return MaxProfit(0, 1, prices, cache);
    }

    private int MaxProfit(int index, int buy, int[] prices, Dictionary<(int, int), int> cache){
        if(index>=prices.Length){
            return 0;
        }
        if(cache.ContainsKey((index,buy))){
            return cache[(index, buy)];
        }
        if(buy == 1){
            var res = Math.Max(-prices[index]+MaxProfit(index+1, 0, prices, cache), MaxProfit(index+1, 1, prices, cache));
            cache[(index, buy)]=res;
            return res;
        }
        else{
            var res = Math.Max(prices[index]+MaxProfit(index+2, 1, prices, cache), MaxProfit(index+1, 0, prices, cache));
            cache[(index, buy)]=res;
            return res;
        }
    }
}