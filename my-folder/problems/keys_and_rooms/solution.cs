public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        var len = rooms.Count;
        var visited = new bool[len];
        var queue = new Queue<int>();
        queue.Enqueue(0);
        while(queue.Count > 0){
            var room = queue.Dequeue();
            var keys = rooms[room];
            visited[room]=true;
            foreach(var key in keys){
                if(!visited[key]){
                    queue.Enqueue(key);
                }                
            }
        }
        return visited.All(r=>r);
    }
}
