public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        var left = 1;
        var right = 1000000000;
        var minCapacity = -1;

        while(left <= right) {
            var capacity = left + (right - left) / 2;
            if(IsPossibleToShip(weights, capacity, days)){
                minCapacity = capacity;
                right = capacity - 1;
            }
            else {
                left = capacity + 1;
            }
        }
        return minCapacity;
    }

    bool IsPossibleToShip(int[] weights, int capacity, int days) {
        var totalDays = 0;
        int i = 0;
        var len = weights.Length;
        while (i < len){
            if(capacity < weights[i]) {
                return false;
            }
            var load = 0;
            while(i < len && load + weights[i] <= capacity) {
                load += weights[i++];
            }
            totalDays++;
        }
        return totalDays <= days;
    }
}