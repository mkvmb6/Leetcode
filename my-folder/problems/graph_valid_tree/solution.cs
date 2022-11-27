public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        var unionFind = new UnionFind(n);
        if(edges.Length != n-1){
            return false;
        }
        foreach(var edge in edges){
            if(!unionFind.Union(edge[0], edge[1])){
                return false;
            }
        }
        return true;
    }
}

public class UnionFind{
    private int[] roots;
    private int[] ranks;
    
    public int Count{get;private set;}
    
    public UnionFind(int size){
        roots = new int[size];
        ranks = new int[size];
        Count = size;
        for(int i=0;i<size;i++){
            roots[i]=i;
            ranks[i]=1;
        }
    }
    
    public int Find(int x){
        var root = roots[x];
        if(x == root){
            return x;
        }
        roots[x]=Find(root);
        return roots[x];
    }
    
    public bool Union(int x, int y){
        var rootX = Find(x);
        var rootY = Find(y);
        if(rootX != rootY){
            if(ranks[rootX] > ranks[rootY]){
                roots[rootY] = rootX;
            }
            else if(ranks[rootY] > ranks[rootX]){
                roots[rootX] = rootY;
            }
            else{
                roots[rootY] = rootX;
                ranks[rootX]++;
            }
            Count--;
            return true;
        }
        return false;
    }
}