public class Solution {
    public int MakeConnected(int n, int[][] connections) {
        var dsu = new DisjointSet(n);
        int unused = connections.Length;
        foreach(var connection in connections){
            if(dsu.Union(connection[0], connection[1])){
                unused--;
            }
        }
        if(dsu.Count==1){
            return 0;
        }
        return dsu.Count-1 <= unused?dsu.Count-1:-1;
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