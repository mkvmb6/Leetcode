public class Solution {
    public int NumEnclaves(int[][] board) {
        var n = board.Length;
        var m = board[0].Length;
        var visited = new bool[n, m];
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if((i==0 || j==0 || i==n-1 || j==m-1 ) && board[i][j]==1){
                    MarkVisited(i, j, n, m, board, visited);
                }
            }
        }
        int enclaves = 0;
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(board[i][j]==1 && !visited[i,j]){
                    enclaves++;
                }
            }
        }
        return enclaves;
    }

    void MarkVisited(int row, int col, int n, int m, int[][] board, bool[,] visited){
        if(visited[row,col]){
            return;
        }
        visited[row,col]=true;
        
        var deltaRow = new int[]{1,0,-1,0};
        var deltaCol = new int[]{0,1,0,-1};
        for(int i=0;i<4;i++){
            var r = row+deltaRow[i];
            var c = col+deltaCol[i];
            if(r>=0 && c >= 0 && r <n && c <m && board[r][c]==1){
                MarkVisited(r, c, n, m, board, visited);
            }            
        }
    }
}