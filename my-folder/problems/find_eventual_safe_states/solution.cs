public class Solution {
    public IList<int> EventualSafeNodes(int[][] graph) {
        var V = graph.Length;
        var safeNodes = new List<int>();
        var safeMarked = new bool[V];
        var inDegree = new int[V];
        var adj = new Dictionary<int, List<int>>();
        for(int i=0;i<V;i++){
            adj[i]=new List<int>();
        }
        for(int i=0;i<V;i++){
            foreach(var item in graph[i]){
                inDegree[i]++;
                adj[item].Add(i);
            }
        }

        var queue = new Queue<int>();
        for(int i=0;i<V;i++){
            if(inDegree[i]==0){
                queue.Enqueue(i);
            }
        }

        while(queue.Any()){
            var node = queue.Dequeue();
            foreach(var item in adj[node]){
                inDegree[item]--;
                if(inDegree[item]==0){
                    queue.Enqueue(item);
                }
            }
            safeMarked[node]=true;
        }
        for(int i=0;i<V;i++){
            if(safeMarked[i]){
                safeNodes.Add(i);
            }
        }
        return safeNodes;
    }
}