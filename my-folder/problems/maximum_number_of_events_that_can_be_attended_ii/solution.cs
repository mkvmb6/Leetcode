public class Solution {
    public int MaxValue(int[][] events, int k) {
        Array.Sort(events, (a, b)=>a[0]-b[0]);
        var cache = new int[events.Length+1,k+1];
        return FindMax(events, 0, k, cache);
    }

    int FindMax(int[][] events, int idx, int k, int[,] cache){
        if(k == 0 || idx >= events.Length){
            return 0;
        }
        if(cache[idx,k]!=0){
            return cache[idx,k];
        }
        int i = idx + 1;
        while(i < events.Length && events[i][0] <= events[idx][1]){
            i++;
        }
        var val1 = events[idx][2] + FindMax(events, i, k - 1, cache);
        var val2 = FindMax(events, idx + 1, k, cache);
        return cache[idx, k] = Math.Max(val1, val2);
    }
}