public class Solution {
    public int MinDifficulty(int[] jobDifficulty, int d) {
        if(d > jobDifficulty.Length){
            return -1;
        }
        var cache = new int[jobDifficulty.Length][];
        for(int i=0;i<jobDifficulty.Length;i++){
           var arr = new int[d + 1];
           Array.Fill(arr, -1);
           cache[i] = arr;
        }
        
        return FindMin(jobDifficulty, 0, d, cache);
    }

    int FindMin(int[] jobs, int n, int d, int[][] cache){
        if(cache[n][d] != -1){
            return cache[n][d];
        }

        if(d == 1) {
            return FindMax(jobs, n);
        }

        var min = int.MaxValue;
        var max = int.MinValue;
        for(int i=n; i <= jobs.Length - d; i++){
            max = Math.Max(max, jobs[i]);
            min = Math.Min(min, max + FindMin(jobs, i + 1, d - 1, cache));
        }
        return cache[n][d] = min;
    }

    int FindMax(int[] arr, int i){
        var max = arr[i];
        for(int j=i+1;j<arr.Length;j++){
            max = Math.Max(max, arr[j]);
        }
        return max;
    }

}