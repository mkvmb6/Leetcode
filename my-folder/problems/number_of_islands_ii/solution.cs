public class Solution {
    public IList<int> NumIslands2(int m, int n, int[][] positions) {
        var dsu = new DisjointSet(m*n);
        var result = new List<int>();
        var edges = new List<int[]>{new int[]{-1,0},new int[]{0,1},new int[]{1,0},new int[]{0,-1}};
        var grid = new int[m, n];
        foreach(var position in positions){
            if(grid[position[0],position[1]]==1){
                result.Add(result.LastOrDefault());
                continue;
            }
            grid[position[0],position[1]]=1;
            var prevCount = dsu.Count;
            foreach(var edge in edges){
                var adjX = position[0]+edge[0];
                var adjY = position[1]+edge[1];
                if(IsValidCell(adjX, adjY, m, n) && grid[adjX, adjY]==1){
                    dsu.Union(n*position[0]+position[1], n*adjX+adjY);
                }
            }
            var prevResult = result.LastOrDefault();
            if(prevCount==dsu.Count){
                result.Add(prevResult+1);
            }
            else{
                result.Add(prevResult+1-(prevCount-dsu.Count));
            }
        }
        return result;
    }


    bool IsValidCell(int x, int y, int m, int n){
        return x>=0 && y>=0 && x < m && y < n;
    }
}



class DisjointSet{
    private int[] ranks;
    private int[] roots;
    
    public int Count{get;set;}
    
    public DisjointSet(int size){
        ranks = new int[size];
        roots = new int[size];
        Count = size;
        for(int i=0;i<size;i++){
            roots[i]=i;
        }
    }
    
    public int Find(int node){
        var root = roots[node];
        if(root == node){
            return root;
        }
        roots[node]=Find(root);
        return roots[node];
    }
    
    public bool Union(int node1, int node2){
        var root1 = Find(node1);
        var root2 = Find(node2);
        if(root1==root2){
            return false;
        }
        var rank1 = ranks[root1];
        var rank2 = ranks[root2];
        if(rank1 > rank2){
            roots[root2]=root1;
        }
        else if(rank2 > rank1){
            roots[root1]=root2;
        }
        else{
            roots[root2]=root1;
            ranks[root1]++;
        }
        Count--;
        return true;
    }
    
}