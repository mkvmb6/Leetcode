public class Solution {
    public int MinDistance(string word1, string word2) {
        var cache = new int[word1.Length, word2.Length];
        return GetMinDistance(word1, word2, 0, 0, cache);
    }

    int GetMinDistance(string word1, string word2, int i, int j, int[,] cache) {
        if(j == word2.Length) {
            return word1.Length - i;
        }
        if(i == word1.Length) {
            return word2.Length - j;
        }
        if(cache[i,j] != 0) {
            return cache[i, j];
        }
        if(word1[i] == word2[j]) {
            return GetMinDistance(word1, word2, i + 1, j + 1, cache);
        }
        var min = int.MaxValue;
        min = Math.Min(min, 1 + GetMinDistance(word1, word2, i, j + 1, cache));
        min = Math.Min(min, 1 + GetMinDistance(word1, word2, i + 1, j, cache));
        min = Math.Min(min, 1 + GetMinDistance(word1, word2, i + 1, j + 1, cache));
        return cache[i,j] = min;
    }
}