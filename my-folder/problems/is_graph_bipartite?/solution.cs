public class Solution {
    public bool IsBipartite(int[][] graph) {
        var n = graph.Length;
        var visited = new int[n];
        for(int i=0;i<n;i++){
            if(!CanColor(graph, visited, i)){
                return false;
            }
        }
        return true;
    }

    bool CanColor(int[][] graph, int[] visited, int node){
        if(visited[node]!=0){
            return true;
        }
        var queue = new Queue<int>();
        visited[node]=1;
        queue.Enqueue(node);
        while(queue.Any()){
            var parent = queue.Dequeue();
            var color = visited[parent];
            var invertColor = (color%2)+1;
            foreach(var n in graph[parent]){
                if(visited[n]==color){
                    return false;
                }
                if(visited[n]==0){
                    visited[n]=invertColor;
                    queue.Enqueue(n);
                }
            }
        }
        return true;
    }
}