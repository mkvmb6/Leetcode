public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        var list = GetManhattanDistanceList(points);
        list.Sort((a, b)=>a.Distance - b.Distance);
        var uf = new UnionFind(points.Length);
        var minCost = 0;
        int i = 0;
        while(uf.Count > 1){
            var pair = list[i++];
            if(uf.Union(pair.Point1, pair.Point2)){
                minCost += pair.Distance;
            }
        }
        return minCost;
    }

    List<PointPair> GetManhattanDistanceList(int[][] points){
        var list = new List<PointPair>();
        for(int i=0;i<points.Length;i++){
            for(int j=i+1;j<points.Length;j++){
                var distance = Math.Abs(points[i][0]-points[j][0])+Math.Abs(points[i][1]-points[j][1]);
                list.Add(new PointPair{Point1=i, Point2=j, Distance= distance});
            }
        }
        return list;
    }
}

class PointPair{
    public int Point1{get;set;}
    public int Point2{get;set;}
    public int Distance{get;set;}
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