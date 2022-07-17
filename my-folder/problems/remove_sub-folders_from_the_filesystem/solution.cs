public class Solution {
    public IList<string> RemoveSubfolders(string[] folder) {
        Array.Sort(folder, (a,b)=>a.Length-b.Length);
        var result = new List<string>();
        var trie = new Trie();
        foreach(var fold in folder){
            if(trie.Insert(fold)){
                result.Add(fold);
            }
        }
        return result;
    }
}

public class Trie {
    public Dictionary<char, Trie> WordMap{get;set;}
    public bool EndsHere{get;set;}

    public Trie() {
        WordMap = new Dictionary<char, Trie>();
    }
    
    public bool Insert(string word) {
        var node = this;
        foreach(char ch in word){
            if(node.EndsHere && ch=='/'){
                return false;
            }
            if(!node.WordMap.ContainsKey(ch)){
                node.WordMap[ch]=new Trie();
            }
            node=node.WordMap[ch];
        }
        node.EndsHere=true;
        return true;
    }
    
}