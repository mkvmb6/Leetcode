public class Solution {
    public int Racecar(int target) {
        var visited = new HashSet<(int, int)>();
        var queue = new Queue<Node>();
        queue.Enqueue(new Node{Position=0, Speed=1, Moves = 0});
        while(queue.Count > 0){
            var node = queue.Dequeue();
            if(node.Position==target){
                return node.Moves;
            }
            var nodeId= (node.Position,node.Speed);
            if(visited.Contains(nodeId)){
                continue;
            }
            visited.Add(nodeId);
            var newNode = new Node{Position=node.Position+node.Speed, Speed=node.Speed*2, Moves = node.Moves+1};
            queue.Enqueue(newNode);
            if((newNode.Position > target && newNode.Speed > 0) || (newNode.Position < target && newNode.Speed < 0)){
                var newSpeed = newNode.Speed > 0? -1 : 1;
                queue.Enqueue(new Node{Position=node.Position, Speed=newSpeed, Moves = node.Moves+1});
            }
        }
        return -1;
    }
}

class Node{
    public int Position{get;set;}
    public int Speed{get;set;}
    public int Moves{get;set;}
}