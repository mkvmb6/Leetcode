public class Solution {
    public int[] FindPeakGrid(int[][] mat) {
        int rows = mat.Length;
        int cols = mat[0].Length;
        for(int i=0; i< rows; i++){                
            int start = 0, end = cols - 1;
            while(start<=end){
                var mid = start + (end - start)/2;
                int up = i>0?mat[i-1][mid]:-1;
                int down = i<rows-1?mat[i+1][mid]:-1;
                int left = mid>0?mat[i][mid-1]:-1;
                int right = mid<cols-1?mat[i][mid+1]:-1;
                int num = mat[i][mid];
                if(IsGreater(num, up, down, left, right)){
                    return new int[]{i, mid};
                }
                else if(left > right){
                    end = mid - 1;
                }
                else{
                    start = mid + 1;
                }
            }
        }
        return new int[]{-1,-1};
    }

    bool IsGreater(int num, params int[] arr){
        return !arr.Any(a=>a>num);
    }
}