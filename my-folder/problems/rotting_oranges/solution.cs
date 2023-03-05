public class Solution {
    public int OrangesRotting(int[][] grid) {
        var queue = new Queue<int[]>();
        int n = grid.Length;
        int m = grid[0].Length;
        var visited = new int[n, m];
        int time = 0;
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(grid[i][j]==2 && visited[i,j]==0){
                    queue.Enqueue(new int[]{i, j, 0});
                }
            }
        }

        while(queue.Any()){
            var data = queue.Dequeue();
            int i=data[0], j = data[1];
            if(visited[i,j]==1){
                continue;
            }
            time = data[2];
            visited[i,j]=1;
            grid[i][j]=2;
            if(i>0 && grid[i-1][j]==1){
                queue.Enqueue(new int[]{i-1,j, time+1});
            }
            if(j>0 && grid[i][j-1]==1){
                queue.Enqueue(new int[]{i,j-1, time+1});
            }
            if(j<m-1 && grid[i][j+1]==1){
                queue.Enqueue(new int[]{i,j+1, time+1});
            }
            if(i<n-1 && grid[i+1][j]==1){
                queue.Enqueue(new int[]{i+1,j, time+1});
            }
        }
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(grid[i][j]==1){
                    return -1;
                }
            }
        }
        return time;
    }
}