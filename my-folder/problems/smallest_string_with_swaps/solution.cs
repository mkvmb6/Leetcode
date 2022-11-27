public class Solution {
    public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs) {
        var len = s.Length;
        var uf = new UnionFind(len);
        foreach(var pair in pairs){
            uf.Union(pair[0], pair[1]);
        }
        
        var rootMap = new Dictionary<int, List<int>>();
        for(int i=0;i<len;i++){
            var root = uf.Find(i);
            if(!rootMap.ContainsKey(root)){
                rootMap[root]=new List<int>();
            }
            rootMap[root].Add(i);
        }
        
        var resultString = new char[len];
        foreach(var list in rootMap.Values){
            var charList = new List<char>();
            foreach(var index in list){
                charList.Add(s[index]);
            }
            charList.Sort();
            
            for(int i=0;i<list.Count;i++){
                resultString[list[i]]=charList[i];
            }
        }
        return new string(resultString);
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