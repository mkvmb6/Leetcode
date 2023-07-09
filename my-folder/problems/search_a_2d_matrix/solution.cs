public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var rows = matrix.Length;
        var cols = matrix[0].Length;
        var left = 0;
        var right = rows*cols - 1;
        while(left<=right){
            var mid = left + (right -left)/2;
            var row = mid / cols;
            var col = mid % cols;
            var item = matrix[row][col];
            if(item==target){
                return true;
            }
            if(item < target){
                left = mid + 1;
            }
            else{
                right = mid - 1;
            }
        }
        return false;
    }
}