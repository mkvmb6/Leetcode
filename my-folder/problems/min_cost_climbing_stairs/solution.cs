public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var cache = new int[cost.Length];
        return Math.Min(MinCostClimbingStairs(0, cost, cache), MinCostClimbingStairs(1, cost, cache));
    }

    int MinCostClimbingStairs(int index, int[] cost, int[] cache) {
        if(index>=cost.Length){
            return 0;
        }
        if(index==cost.Length-1 || index==cost.Length-2){
            return cost[index];
        }
        
        if(cache[index] != 0){
            return cache[index];
        }
        var res = Math.Min(cost[index]+MinCostClimbingStairs(index+1, cost, cache), cost[index]+MinCostClimbingStairs(index+2, cost, cache));
        cache[index]=res;
        return res;
    }
}