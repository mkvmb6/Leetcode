public class Solution {
    public IList<int> EventualSafeNodes(int[][] graph) {
        var V = graph.Length;
        var visited = new bool[V];
        var pathVisited = new bool[V];
        var safeNodes = new List<int>();
        var safeMarked = new bool[V];
        for(int i=0;i<V;i++){
            isCyclic(i, graph, visited, pathVisited, safeMarked);
        }
        for(int i=0;i<V;i++){
            if(safeMarked[i]){
                safeNodes.Add(i);
            }
        }
        return safeNodes;
    }
    
    bool isCyclic(int node, int[][] adj, bool[] visited, bool[] pathVisited, bool[] safeMarked){
        if(visited[node]){
            return false;
        }
        
        visited[node] = true;
        pathVisited[node] = true;
        foreach(var child in adj[node]){
            if(pathVisited[child]){
                return true;
            }
            if(isCyclic(child, adj, visited, pathVisited, safeMarked)){
                return true;
            }
        }
        pathVisited[node] = false;
        safeMarked[node] = true;
        return false;
    }
}