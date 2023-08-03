public class Solution {
    public int UniquePaths(int m, int n) {
        var cache = new int[m, n];
        return GetUniquePaths(m, n, 0, 0, cache);
    }

    int GetUniquePaths(int m, int n, int i, int j, int[,] cache) {
        if(i == m - 1 && j == n - 1) {
            return 1;
        }
        if(i >= m || j >= n) {
            return 0;
        }

        if(cache[i, j] != 0) {
            return cache[i, j];
        }

        return cache[i, j] = GetUniquePaths(m, n, i + 1, j, cache) + GetUniquePaths(m, n, i, j + 1, cache);
    }
}