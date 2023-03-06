public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        var n = mat.Length;
        var m = mat[0].Length;
        var result = new int[n][];
        
        for(int i=0;i<n;i++){
            result[i]=new int[m];
            for(int j=0;j<m;j++){
                result[i][j]=int.MaxValue;
            }
        }

        var queue = new Queue<(int row, int col)>();
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(mat[i][j]==0){
                    queue.Enqueue((i,j));
                    result[i][j]=0;
                }
            }
        }
        var visited = new bool[n,m];

        while(queue.Any()){
            var pair = queue.Dequeue();
            if(visited[pair.row,pair.col]){
                continue;
            }
            visited[pair.row,pair.col]=true;
            var deltaRow = new int[]{1,0,-1,0};
            var deltaCol = new int[]{0,1,0,-1};
            for(int i=0;i<4;i++){
                var row = pair.row+deltaRow[i];
                var col = pair.col+deltaCol[i];
                if(row<0 || col < 0 || row >=n || col >=m){
                    continue;
                }
                result[row][col]=Math.Min(result[row][col], result[pair.row][pair.col]+1);
                queue.Enqueue((row, col));
            }
        }
        return result;
    }
}