public class Solution {
    public bool PossibleBipartition(int n, int[][] dislikes) {
        var map = new Dictionary<int, List<int>>();
        foreach(var dislike in dislikes){
            int x = dislike[0], y = dislike[1];
            if(!map.ContainsKey(x)){
                map[x]=new List<int>();
            }
            if(!map.ContainsKey(y)){
                map[y]=new List<int>();
            }
            map[x].Add(y);
            map[y].Add(x);
        }
        var uf = new UnionFind(n+1);
        for(int i=1;i<=n;i++){
            if(map.ContainsKey(i)){
                foreach(var dislike in map[i]){
                    if(uf.Find(i)==uf.Find(dislike)){
                        return false;
                    }
                    uf.Union(map[i][0], dislike);
                }
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