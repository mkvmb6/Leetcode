public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b)=>a[0]-b[0]);
        var result = new List<int[]>{intervals[0]};        
        var len = intervals.Length;
        var j = 0;
        for(int i=1;i<len;i++){
            if(result[j][1] >= intervals[i][0]){
                result[j][1]=Math.Max(result[j][1], intervals[i][1]);
            }
            else{
                result.Add(intervals[i]);
                j++;
            }
        }
        return result.ToArray();
    }
}