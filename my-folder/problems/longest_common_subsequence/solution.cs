public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        var cache = new int[text1.Length + 1, text2.Length + 1];
        for(int i=1;i<=text1.Length;i++) {
            for(int j=1;j<=text2.Length;j++){
                if(text1[i-1] == text2[j-1]) {
                    cache[i, j] = 1 + cache[i-1, j-1];
                }
                else {
                    cache[i, j] = Math.Max(cache[i, j-1], cache[i-1, j]);
                }
            }
        }
        return cache[text1.Length,text2.Length];
    }
}