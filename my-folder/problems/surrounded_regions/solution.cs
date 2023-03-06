public class Solution {
    public void Solve(char[][] board) {
        var n = board.Length;
        var m = board[0].Length;
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if((i==0 || j==0 || i==n-1 || j==m-1 ) && board[i][j]=='O'){
                    MarkVisited(i, j, n, m, board);
                }
            }
        }
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(board[i][j]=='M'){
                    board[i][j]='O';
                }
                else if(board[i][j]=='O'){
                    board[i][j]='X';
                }
            }
        }
    }

    void MarkVisited(int row, int col, int n, int m, char[][] board){
        if(board[row][col]=='M'){
            return;
        }
        board[row][col]='M';
        
        var deltaRow = new int[]{1,0,-1,0};
        var deltaCol = new int[]{0,1,0,-1};
        for(int i=0;i<4;i++){
            var r = row+deltaRow[i];
            var c = col+deltaCol[i];
            if(r>=0 && c >= 0 && r <n && c <m && board[r][c]=='O'){
                MarkVisited(r, c, n, m, board);
            }            
        }
    }
}