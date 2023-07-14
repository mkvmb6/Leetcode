public class Solution {
    public int LongestSubsequence(int[] arr, int difference) {
        var maxLen = 1;
        var map = new Dictionary<int, int>();
        foreach(var num in arr){
            var len = 1 + map.GetValueOrDefault(num - difference, 0);
            map[num] = len;
            maxLen = Math.Max(maxLen, len);
        }
        return maxLen;
    }
}