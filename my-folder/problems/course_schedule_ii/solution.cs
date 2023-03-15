public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var adj = new Dictionary<int, List<int>>();
        var inDegree = new int[numCourses];
        foreach(var preq in prerequisites){
            if(!adj.ContainsKey(preq[0])){
                adj[preq[0]]=new List<int>();
            }
            adj[preq[0]].Add(preq[1]);
            inDegree[preq[1]]++;
        }

        var stack = new Stack<int>();
        var queue = new Queue<int>();
        for(int i=0;i<numCourses;i++){
            if(inDegree[i]==0){
                queue.Enqueue(i);
            }
        }
        while(queue.Any()){
            var course = queue.Dequeue();
            stack.Push(course);
            if(adj.ContainsKey(course)){
                foreach(var ch in adj[course]){
                    inDegree[ch]--;
                    if(inDegree[ch]==0){
                        queue.Enqueue(ch);
                    }
                }
            }            
        }
        if(stack.Count!=numCourses){
            return new int[0];
        }
        int j = 0;
        while(stack.Any()){
            inDegree[j++]=stack.Pop();
        }
        return inDegree;
        
    }
}