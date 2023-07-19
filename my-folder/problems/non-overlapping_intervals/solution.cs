public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b)=>a[0] - b[0]);
        var count = 0;
        var current = intervals[0];
        for(int i=1;i<intervals.Length;i++){
            if(current[1] <= intervals[i][0]){
                current = intervals[i];
                continue;
            }
            count++;
            current = current[1] < intervals[i][1] ? current : intervals[i];
        }
        return count;
    }
}