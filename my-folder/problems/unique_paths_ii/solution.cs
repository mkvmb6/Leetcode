public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        var m = obstacleGrid.Length;
        var n = obstacleGrid[0].Length;
        if(obstacleGrid[m-1][n-1] == 1) {
            return 0;
        } 
        var cache = new int[m, n];
        return GetUniquePaths(obstacleGrid, m, n, 0, 0, cache);
    }

    int GetUniquePaths(int[][] grid, int m, int n, int i, int j, int[,] cache) {
        if(i == m - 1 && j == n - 1) {
            return 1;
        }
        if(i >= m || j >= n || grid[i][j] == 1) {
            return 0;
        }

        if(cache[i, j] != 0) {
            return cache[i, j];
        }

        return cache[i, j] = GetUniquePaths(grid, m, n, i + 1, j, cache) + GetUniquePaths(grid, m, n, i, j + 1, cache);
    }
}