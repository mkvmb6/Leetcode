public class Solution {
    public int[][] GenerateMatrix(int n) {        
		var spiral = new List<int>();
        var top = 0;
        var left = 0;
        var bottom = n-1;
        var right = n-1;        
        var matrix = new int[n][];
        for(int i=0;i<n;i++){
            matrix[i]=new int[n];
        }
        var counter = 1;
        while(top<=bottom && left<=right){
            for(int i=left;i<=right;i++){
                matrix[top][i]=counter++;
            }
            top++;
            for(int i=top;i<=bottom;i++){
                matrix[i][right]=counter++;
            }
            right--;
            if(top<=bottom){
                for(int i=right;i>=left;i--){
                    matrix[bottom][i]=counter++;
                }
                bottom--;
            }
            
            if(left<=right){                
                for(int i=bottom;i>=top;i--){
                    matrix[i][left]=counter++;
                }
                left++;
            }
        }
        
		return matrix;
    }
}