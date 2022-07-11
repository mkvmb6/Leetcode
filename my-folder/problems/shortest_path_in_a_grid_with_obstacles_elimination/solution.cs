public class Solution {
    public int ShortestPath(int[][] grid, int k) {
        var minHeap = new PriorityQueue<Node, int>();
        var rows = grid.Length;
        var cols = grid[0].Length;
        var visited = new Dictionary<string, int>();
        minHeap.Enqueue(new Node{Row=rows-1,Col=cols-1,Weight=-1,Steps=0, Obstacles=k}, -1);
        var directions = new int[][]{new int[]{1,0}, new int[]{0,1}, new int[]{0,-1},new int[]{-1,0}};
        while(minHeap.Count > 0){
            var node = minHeap.Dequeue();
            if(node.Obstacles >= node.Row +  node.Col - 1){
                return node.Steps + node.Row + node.Col;
            }
            foreach(var direction in directions){
                var nextRow = node.Row + direction[0];
                if(nextRow==-1 || nextRow>=rows){
                    continue;
                }
                var nextCol = node.Col + direction[1];
                if(nextCol==-1 || nextCol >= cols){
                    continue;
                }
                var nextObstacles = grid[nextRow][nextCol]==1?node.Obstacles-1:node.Obstacles;
                if(nextObstacles < 0){
                    continue;
                }
                var nextWeight = nextRow + nextCol + node.Steps + 1;
                var nextNode = new Node{Row=nextRow, Col=nextCol, Weight=nextWeight, Steps=node.Steps+1, Obstacles=nextObstacles};
                var id = $"{nextNode.Row}{nextNode.Col}";
                if(!visited.ContainsKey(id) || visited[id] < nextNode.Obstacles){
                    visited[id]=nextNode.Obstacles;
                    minHeap.Enqueue(nextNode, nextNode.Weight);
                }
            }
        }
        return -1;
    }
}

class Node{
    public int Row{get;set;}
    public int Col{get;set;}
    public int Weight{get;set;}
    public int Steps{get;set;}
    public int Obstacles{get;set;}
}