public class Solution {
    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts) {
        var len = accounts.Count;
        var uf = new UnionFind(len);
        var emailGroup = new Dictionary<string, int>();
        for(int i=0;i<len;i++){
            for(int j=1;j<accounts[i].Count;j++){
                var email = accounts[i][j];
                if(emailGroup.ContainsKey(email)){
                    uf.Union(i, emailGroup[email]);
                }
                else{
                    emailGroup[email]=i;
                }
            }
        }
        
        var components = new Dictionary<int, IList<string>>();
        
        foreach(var emailKey in emailGroup.Keys){
            var root = uf.Find(emailGroup[emailKey]);
            if(!components.ContainsKey(root)){
                components[root]=new List<string>();
            }
            components[root].Add(emailKey);
        }
        
        var mergedAccounts = new List<IList<string>>();
        foreach(var componentPair in components){
           var emails = componentPair.Value.OrderBy(x=>x, StringComparer.Ordinal).ToList();
            emails.Insert(0, accounts[componentPair.Key][0]);
            mergedAccounts.Add(emails);
        }
        
        return mergedAccounts;
        
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