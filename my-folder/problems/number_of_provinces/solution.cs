public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        var len = isConnected.Length;
        var visited = new int[len];
        var provinces = 0;
        for(int i=0;i<len;i++){
            if(visited[i]==0){
                provinces++;
                VisitConnectedCities(i, isConnected, visited, len);
            }
        }

        return provinces;
    }

    void VisitConnectedCities(int i, int[][] isConnected, int[] visited, int len){
        if(visited[i]==1){
            return;
        }
        visited[i]=1;
        for(int j=0;j<len;j++){
            if(isConnected[i][j]==1){
                VisitConnectedCities(j, isConnected, visited, len);
            }
        }
    }
}