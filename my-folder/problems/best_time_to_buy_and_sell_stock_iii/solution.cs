public class Solution {
    public int MaxProfit(int[] prices) {
        var len = prices.Length;
        var profits = new int[len];
        var maxProfit = 0;
        var minBuy = prices[0];
        for(int i=1;i<len;i++){
            minBuy = Math.Min(minBuy, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i]-minBuy);
            profits[i]=maxProfit;
        }
        var result = 0;
        var maxSell = prices[len-1];
        maxProfit = 0;
        
        for(int i=len-2;i>=0;i--){
            maxSell = Math.Max(maxSell, prices[i]);
            maxProfit = Math.Max(maxProfit, maxSell - prices[i]);
            result = Math.Max(result, profits[i]+maxProfit);
        }
        return result;
    }
}