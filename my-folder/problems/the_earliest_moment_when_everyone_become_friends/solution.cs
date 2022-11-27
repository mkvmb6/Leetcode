public class Solution {
    public int EarliestAcq(int[][] logs, int n) {
        Array.Sort(logs, (a, b)=>a[0]-b[0]);
        var unionFind = new UnionFind(n);
        foreach(var log in logs){
            unionFind.Union(log[1], log[2]);
            if(unionFind.Count == 1){
                return log[0];
            }
        }
        return -1;
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
    
    public void Union(int x, int y){
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
        }
    }
}