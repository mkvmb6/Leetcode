public class Solution {
    public int MaxProfit(int[] prices) {
        var min = prices[0];
        var maxProfit = 0;
        for(int i=1;i<prices.Length;i++){
            min = Math.Min(min, prices[i]);
            maxProfit=Math.Max(maxProfit, prices[i]-min);
        }    
        return maxProfit;
    }
}