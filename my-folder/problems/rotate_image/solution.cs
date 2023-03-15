public class Solution {
    public void Rotate(int[][] matrix) {
        var n = matrix.Length;
        for(int i=0;i<n;i++){
            for(int j=i;j<n;j++){
                Swap(matrix, i, j, j, i);
            }
        }
        for(int i=0;i<n;i++){
            Reverse(matrix, i);
        }

    }

    void Swap(int[][] arr, int i1, int j1, int i2, int j2){
        var temp = arr[i1][j1];
        arr[i1][j1] = arr[i2][j2];
        arr[i2][j2] = temp;
    }

    void Reverse(int[][] arr, int row){
        var len = arr[row].Length;
        var left = 0;
        var right = len - 1;
        while(left<right){
            Swap(arr, row, left++, row, right--);
        }
    }
}