public class Solution {
    public long MaxRunTime(int n, int[] batteries) {
        long left = int.MaxValue;
        long right = 0;
        foreach(var battery in batteries){
            right += battery;
            left = Math.Min(left, battery);
        }
        long maxTime = 0;
        while(left <= right) {
            var mid = left + (right - left) / 2;
            if(IsRunPossible(mid, batteries, n)) {
                maxTime = mid;
                left = mid + 1;
            }
            else {
                right = mid - 1;
            }
        }
        return maxTime;
    }

    bool IsRunPossible(long mid, int[] batteries, int n) {
        var target = n * mid;
        foreach(var battery in batteries) {
            target -= Math.Min(battery, mid);
            if(target <= 0) {
                return true;
            }
        }
        return false;
    }
}