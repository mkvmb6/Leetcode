public class Solution {
    public int NumIslands(char[][] grid) {
        int isLands = 0;
        var rows = grid.Length;
        var cols = grid[0].Length;
        for(int i=0;i<rows;i++){
            for(int j=0;j<cols;j++){
                isLands+= ProcessIsland(grid, i, j);
            }
        }
        return isLands;
    }
    
    
    private int ProcessIsland(char[][] grid, int row, int col){
        var rows = grid.Length;
        var cols = grid[0].Length;
        if(row<0 || col<0 || row>=rows || col>=cols || grid[row][col]=='0'){
            return 0;
        }
        grid[row][col]='0';
        ProcessIsland(grid, row+1, col);
        ProcessIsland(grid, row, col+1);
        ProcessIsland(grid, row-1, col);
        ProcessIsland(grid, row, col-1);
        return 1;
    }
    
    
}