public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var adj = new Dictionary<int, List<int>>();
        var inDegree = new int[numCourses];
        foreach(var preq in prerequisites){
            if(!adj.ContainsKey(preq[0])){
                adj[preq[0]]=new List<int>();
            }
            adj[preq[0]].Add(preq[1]);
            inDegree[preq[1]]++;
        }

        var outCount = 0;
        var queue = new Queue<int>();
        for(int i=0;i<numCourses;i++){
            if(inDegree[i]==0){
                queue.Enqueue(i);
            }
        }
        while(queue.Any()){
            var course = queue.Dequeue();
            outCount++;
            if(adj.ContainsKey(course)){
                foreach(var ch in adj[course]){
                    inDegree[ch]--;
                    if(inDegree[ch]==0){
                        queue.Enqueue(ch);
                    }
                }
            }            
        }
        return outCount == numCourses;
    }
}