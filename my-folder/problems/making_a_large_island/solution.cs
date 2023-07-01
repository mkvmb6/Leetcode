public class Solution {
    public int LargestIsland(int[][] grid) {
        var n = grid.Length;
        var dsu = new DisjointSet(n*n);
        var edges = new List<int[]>{new int[]{-1,0},new int[]{0,1},new int[]{1,0},new int[]{0,-1}};
        var maxComponent = 0;
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                if(grid[i][j]!=1){
                    continue;
                }
                foreach(var edge in edges){
                    var adjX = i+edge[0];
                    var adjY = j+edge[1];
                    if(IsAdjacentOne(adjX, adjY, n, grid)){
                        dsu.UnionBySize(n*i+j, n*adjX+adjY);
                    }
                }
            }
        }
        
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                if(grid[i][j]!=0){
                    continue;
                }
                var newSize = 1;
                var rootSet = new HashSet<int>();
                foreach(var edge in edges){
                    var adjX = i+edge[0];
                    var adjY = j+edge[1];
                    if(IsAdjacentOne(adjX, adjY, n, grid)){
                        rootSet.Add(dsu.Find(n*adjX+adjY));
                    }
                }
                foreach(var root in rootSet){
                    newSize+= dsu.FindSize(root);
                }
                maxComponent=Math.Max(maxComponent, newSize);
            }
        }
        
        return maxComponent==0?n*n:maxComponent;
    }


    bool IsAdjacentOne(int x, int y, int n, int[][] grid){
        return x>=0 && y>=0 && x < n && y < n && grid[x][y]==1;
    }
}


class DisjointSet{
    private int[] ranks;
    private int[] roots;
    private int[] sizes;
    
    public int Count{get;set;}
    public int Max{get;set;}
    
    public DisjointSet(int size){
        ranks = new int[size];
        roots = new int[size];
        sizes = new int[size];
        Count = size;
        for(int i=0;i<size;i++){
            roots[i]=i;
            sizes[i]=1;
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

    public int FindSize(int node){
        return sizes[Find(node)];
    }
    
    public bool UnionBySize(int node1, int node2){
        var root1 = Find(node1);
        var root2 = Find(node2);
        if(root1==root2){
            return false;
        }
        var size1 = sizes[root1];
        var size2 = sizes[root2];
        if(size1 > size2){
            roots[root2]=root1;
            sizes[root1]+=sizes[root2];
        }
        else{
            roots[root1]=root2;
            sizes[root2]+=sizes[root1];
        }
        Count--;
        return true;
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