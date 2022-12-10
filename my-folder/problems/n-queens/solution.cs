public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        var board = GetEmptyBoard(n);
        var result = new List<IList<string>>();
        var columns = new int[n];
        var upperDiagonal = new int[2*n - 1];
        var lowerDiagonal = new int[2*n - 1];
        FindQueenPositions(0, board, n, result, columns, upperDiagonal, lowerDiagonal);
        return result;
    }

    private void FindQueenPositions(int index, IList<IList<char>> board, int n, IList<IList<string>> result, int[] columns,int[] upperDiagonal,int[] lowerDiagonal){
        if(index==n){
            result.Add(GetBoardClone(board));
            return;
        }
        for(int i=0;i<n;i++){
            if(!QueenAttack(index, i, n, columns, upperDiagonal, lowerDiagonal)){
                board[index][i]='Q';
                columns[i]=1;
                upperDiagonal[n-1+i-index]=1;
                lowerDiagonal[index+i]=1;
                FindQueenPositions(index+1, board, n, result, columns, upperDiagonal, lowerDiagonal);
                upperDiagonal[n-1+i-index]=0;
                lowerDiagonal[index+i]=0;
                columns[i]=0;
                board[index][i]='.';
            }
        }
    }

    private IList<string> GetBoardClone(IList<IList<char>> board){
        var result = new List<string>();
        foreach(var charList in board){
            result.Add(new string(charList.ToArray()));
        }
        return result;
    }

    private bool QueenAttack(int row, int col, int n, int[] columns,int[] upperDiagonal,int[] lowerDiagonal){
        return columns[col]==1 || upperDiagonal[n-1+col-row]==1 || lowerDiagonal[row+col]==1;
    }

    private IList<IList<char>> GetEmptyBoard(int n){
        var board = new List<IList<char>>();
        var emptyRow= new List<char>();
        for(int i=0;i<n;i++){
            emptyRow.Add('.');
        }
        for(int i=0;i<n;i++){
            board.Add(emptyRow.ToList());
        }
        return board;
    }
}