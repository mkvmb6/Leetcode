public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;
        var rows = grid.Length;
        var cols = grid[0].Length;
        for(int i=0;i<rows;i++){
            for(int j=0;j<cols;j++){
                maxArea=Math.Max(maxArea, GetArea(grid, i, j));
            }
        }
        return maxArea;
    }
    
    private int GetArea(int[][] grid, int row, int col){
        var rows = grid.Length;
        var cols = grid[0].Length;
        if(row<0 || col<0 || row>=rows || col>=cols || grid[row][col]==0){
            return 0;
        }
        var area = 1;
        grid[row][col]=0;
        area+=GetArea(grid, row+1, col);
        area+=GetArea(grid, row, col+1);
        area+=GetArea(grid, row-1, col);
        area+=GetArea(grid, row, col-1);
        return area;
    }
}