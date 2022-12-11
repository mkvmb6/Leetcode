public class Solution {
    public void SolveSudoku(char[][] board) {
        FillBoard(board);
    }

    bool FillBoard(char[][] board){
        for(int i=0;i<9;i++){
            for(int j=0;j<9;j++){
                if(board[i][j]=='.'){
                    for(int num=49;num<=57;num++){
                        if(IsValid(board,i, j, num)){
                            board[i][j]=(char)num;
                            if(FillBoard(board)){
                                return true;
                            }
                            else{
                                board[i][j]='.';
                            }
                        }
                    }
                    return false;
                }                
            }
        }        
        return true;
    }

    bool IsValid(char[][] board, int row, int col, int num){
        var ch = (char)num;
        for(int i=0;i<9;i++){
            if(board[row][i]==ch || board[i][col]==ch){
                return false;
            }
            if(board[3*(row/3)+i/3][3*(col/3)+i%3]==ch){
                return false;
            }
        }
        return true;
    }
}











