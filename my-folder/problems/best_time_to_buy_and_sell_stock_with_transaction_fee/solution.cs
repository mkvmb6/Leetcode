public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        var cache = new int[prices.Length, 2];
        return GetMaxProfit(prices, fee, 0, 1, cache);
    }

    int GetMaxProfit(int[] prices, int fee, int i, int toBuy, int[,] cache) {
        if(i >= prices.Length) {
            return 0;
        }
        if(cache[i, toBuy] != 0) {
            return cache[i, toBuy];
        }
        var profit = int.MinValue;
        if(toBuy == 1) {
            profit = GetMaxProfit(prices, fee, i + 1, 0, cache) - prices[i] - fee;
            profit = Math.Max(profit, GetMaxProfit(prices, fee, i + 1, 1, cache));
        }
        else {
            profit = prices[i] + GetMaxProfit(prices, fee, i + 1, 1, cache);
            profit = Math.Max(profit, GetMaxProfit(prices, fee, i + 1, 0, cache));
        }
        return cache[i, toBuy] = profit;
    }
}