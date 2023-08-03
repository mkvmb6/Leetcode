public class Solution {
    public int MincostTickets(int[] days, int[] costs) {
        var cache = new int[days.Length];
        return GetMinCost(days, costs, 0, new int[]{1,7,30}, cache);
    }

    int GetMinCost(int[] days, int[] costs, int i, int[] validity, int[] cache) {
        if(i >= days.Length) {
            return 0;
        }
        if(cache[i] != 0) {
            return cache[i];
        }
        var minCost = int.MaxValue;
        var j = 0;
        foreach(var cost in costs) {
            var k = i;
            while(k < days.Length && days[k] < days[i] + validity[j]) {
                k++;
            }
            minCost = Math.Min(minCost, cost + GetMinCost(days, costs, k, validity, cache));
            j++;
        }
        return cache[i] = minCost;
    }
}