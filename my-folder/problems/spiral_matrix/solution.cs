public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
		var spiral = new List<int>();
        var top = 0;
        var left = 0;
        var bottom = matrix.Length-1;
        var right = matrix[0].Length - 1;

        while(top<=bottom && left<=right){
            for(int i=left;i<=right;i++){
                spiral.Add(matrix[top][i]);
            }
            top++;
            for(int i=top;i<=bottom;i++){
                spiral.Add(matrix[i][right]);
            }
            right--;
            if(top<=bottom){
                for(int i=right;i>=left;i--){
                    spiral.Add(matrix[bottom][i]);
                }
                bottom--;
            }
            
            if(left<=right){                
                for(int i=bottom;i>=top;i--){
                    spiral.Add(matrix[i][left]);
                }
                left++;
            }
        }
        
		return spiral;
    }
}