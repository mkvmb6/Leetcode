public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        var len = isConnected.Length;
        var unionFind = new UnionFind(len);
        for(int i=0;i<len;i++){
            for(int j=0;j<len;j++){
                if(isConnected[i][j]==1){
                    unionFind.Union(i, j);
                }                
            }
        }
        
        return unionFind.Count;
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