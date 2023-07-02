public class Solution {
    public int RemoveStones(int[][] stones) {
        var (rows, cols) = GetRowsCols(stones);
        var dsuSize = rows+cols+2;
        var dsu = new DisjointSet(dsuSize);
        foreach(var stone in stones){
            dsu.UnionBySize(stone[0], stone[1]+rows+1);
        }

        var roots = new HashSet<int>();
        for(int i=0;i<dsuSize;i++){
            roots.Add(dsu.Find(i));
        }
        var bigComponents = 0;
        foreach(var root in roots){
            if(dsu.FindSize(root)>1){
                bigComponents++;
            }
        }
        return stones.Length - bigComponents;
    }

    (int rows, int cols) GetRowsCols(int[][] stones){
        var rows= 0;
        var cols = 0;
        foreach(var stone in stones){
            rows = Math.Max(stone[0], rows);
            cols = Math.Max(stone[1], cols);
        }
        return (rows, cols);
    }
}


class DisjointSet{
    private int[] ranks;
    private int[] roots;
    private int[] sizes;
    
    public int Count{get;set;}
    
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