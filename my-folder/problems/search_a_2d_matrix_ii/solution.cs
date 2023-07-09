public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
		var rows = matrix.Length;
        var cols = matrix[0].Length;
        var row = 0;
        var col = cols - 1;

        while(row < rows && col >= 0){
            var item = matrix[row][col];
            if(item == target){
                return true;
            }
            if(target < item){
                col--;
            }
            else{
                row++;
            }
        }
        
		return false;
        
    }
}