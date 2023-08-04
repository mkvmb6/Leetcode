public class Solution {
    public int MaxSatisfaction(int[] satisfaction) {
        Array.Sort(satisfaction);
        var cache = new int[satisfaction.Length, satisfaction.Length + 1];
        return GetMax(satisfaction, 0, 1, cache);
    }

    int GetMax(int[] satisfaction, int idx, int time, int[,] cache) {
        if(idx >= satisfaction.Length) {
            return 0;
        }
        if(cache[idx, time] != 0) {
            return cache[idx, time];
        }
        return cache[idx, time] = Math.Max(satisfaction[idx]*time + GetMax(satisfaction, idx + 1, time + 1, cache), 
        GetMax(satisfaction, idx + 1, time, cache));
    }
}