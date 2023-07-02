public class Solution {
    public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections) {
        var adj = new List<IList<int>>();
        for(int i=0;i<n;i++){
            adj.Add(new List<int>());
        }
        foreach(var connection in connections){
            adj[connection[0]].Add(connection[1]);
            adj[connection[1]].Add(connection[0]);
        }
        var bridges = new List<IList<int>>();
        var visited = new bool[n];
        var insertTime = new int[n];
        var lowestTime = new int[n];
        var timer = 0;
        FindBridges(0, -1, adj, bridges, visited, insertTime, lowestTime, ref timer);
        return bridges;
    }

    void FindBridges(int node, int parent, IList<IList<int>> adj, IList<IList<int>> bridges, bool[] visited, int[] insertTime, int[] lowestTime, ref int timer){
        visited[node]=true;
        insertTime[node]=timer;
        lowestTime[node]=timer;
        timer++;
        foreach(var edge in adj[node]){
            if(edge==parent){
                continue;
            }
            if(!visited[edge]){
                FindBridges(edge, node, adj, bridges, visited, insertTime, lowestTime, ref timer);
                lowestTime[node]=Math.Min(lowestTime[node], lowestTime[edge]);
                if(insertTime[node]<lowestTime[edge]){
                    bridges.Add(new List<int>{node, edge});
                }
            }else{
                lowestTime[node]=Math.Min(lowestTime[node], lowestTime[edge]);
            }
        }
    }
}