public class Solution {
    public int[][] Transpose(int[][] matrix) {
        int rows = matrix.Length;
            int cols = matrix[0].Length;
        var res = new int[cols][];
        
        for(int i=0;i<cols;i++){
            res[i]=new int[rows];
            for(int j=0;j<rows;j++){
                res[i][j]=matrix[j][i];
            }
        }
        return res;
    }
}