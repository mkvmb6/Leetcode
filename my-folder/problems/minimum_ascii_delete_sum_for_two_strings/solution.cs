public class Solution {
    public int MinimumDeleteSum(string s1, string s2) {
        var cache = new int[s1.Length + 1, s2.Length + 1];
        return GetMinDelSum(s1, s2, 0, 0, cache);
    }

    int GetMinDelSum(string s1, string s2, int i, int j, int[,] cache) {
        if(i == s1.Length && j == s2.Length) {
            return 0;
        }
        if(i == s1.Length) {
            int sum = 0;
            while(j < s2.Length) {
                sum += s2[j++];
            }
            return sum;
        }
        if(j == s2.Length) {
            int sum = 0;
            while(i < s1.Length) {
                sum += s1[i++];
            }
            return sum;
        }

        if(cache[i, j] != 0) {
            return cache[i, j];
        }

        if(s1[i] == s2[j]) {
            return GetMinDelSum(s1, s2, i + 1, j + 1, cache);
        }
        return cache[i, j] = Math.Min(s2[j] + GetMinDelSum(s1, s2, i, j + 1, cache), s1[i] + GetMinDelSum(s1, s2, i + 1, j, cache));
    }
}