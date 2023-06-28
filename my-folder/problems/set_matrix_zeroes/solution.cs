public class Solution {
    public void SetZeroes(int[][] matrix) {
        var n = matrix.Length;
        var m = matrix[0].Length;
        var colNeedsToBeZero = false;

        for(int i=0;i<n;i++){
            if(matrix[i][0]==0){
                colNeedsToBeZero = true;
            }
            for(int j=1;j<m;j++){
                if(matrix[i][j]==0){
                    matrix[0][j] = 0;
                    matrix[i][0] = 0;
                }
            }
        }

        
        for(int i=1;i<n;i++){
            for(int j=1;j<m;j++){
                if(matrix[0][j]==0 || matrix[i][0]==0){
                    matrix[i][j]=0;
                }
            }
        }

        if(matrix[0][0]==0){
            for(int i=1;i<m;i++){
                matrix[0][i]=0;
            }
        }

        if(colNeedsToBeZero){
            for(int i=0;i<n;i++){
                matrix[i][0]=0;
            }
        }

    }
}