public class Solution {
    public int NumDistinctIslands(int[][] grid) {
        var n = grid.Length;
        var m = grid[0].Length;
        var visited = new bool[n, m];
        var islands = new HashSet<string>();
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                var island = GetIslands(grid, visited, i, j, n, m, "S");
                if(island != "S")
                {
                    islands.Add(island);
                }
            }
        }
        return islands.Count;
    }

    string GetIslands(int[][] grid, bool[,] visited, int row, int col, int n, int m, string dir){
        if(row < 0 || col < 0 || row >= n || col >= m || visited[row, col] || grid[row][col]==0){
            return dir;
        }
        visited[row, col] = true;
        dir += GetIslands(grid, visited, row - 1, col, n, m, "U");
        dir += GetIslands(grid, visited, row + 1, col, n, m, "D");
        dir += GetIslands(grid, visited, row, col - 1, n, m, "L");
        dir += GetIslands(grid, visited, row, col + 1, n, m, "R");
        return dir;
    }
}