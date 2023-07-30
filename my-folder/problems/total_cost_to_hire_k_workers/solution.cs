public class Solution {
    public long TotalCost(int[] costs, int k, int candidates) {
        var pq = new PriorityQueue<int, (int side,int val)>(Comparer<(int side,int val)>.Create((a, b)=>{
            var diff = a.val - b.val;
            if(diff == 0) {
                diff = a.side - b.side;
            }
            return diff;
        }));
        
        for(int i=0;i<candidates;i++){
            pq.Enqueue(costs[i], (0, costs[i]));
        }
        
        for(int i=Math.Max(candidates, costs.Length - candidates);i < costs.Length;i++){
            pq.Enqueue(costs[i], (1, costs[i]));
        }
        var left = candidates;
        var right = costs.Length - candidates - 1;
        long totalCost = 0;

        while(k > 0) {
            pq.TryDequeue(out var cost, out var priority);
            totalCost += cost;
            k--;
            if(left <= right) {
                if(priority.side == 0) {
                    pq.Enqueue(costs[left], (0, costs[left]));
                    left++;
                }
                else{
                    pq.Enqueue(costs[right], (1, costs[right]));
                    right--;
                }
            }
        }
        return totalCost;
        
    }
}