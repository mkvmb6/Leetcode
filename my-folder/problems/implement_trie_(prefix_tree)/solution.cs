public class Trie {
    public Dictionary<char, Trie> WordMap{get;set;}
    public bool EndsHere{get;set;}

    public Trie() {
        WordMap = new Dictionary<char, Trie>();
    }
    
    public void Insert(string word) {
        var node = this;
        foreach(char ch in word){
            if(!node.WordMap.ContainsKey(ch)){
                node.WordMap[ch]=new Trie();
            }
            node=node.WordMap[ch];
        }
        node.EndsHere=true;
    }
    
    public bool Search(string word) {
        var node = this;
        foreach(char ch in word){
            if(!node.WordMap.ContainsKey(ch)){
                return false;
            }
            node=node.WordMap[ch];
        }
        return node.EndsHere;
    }
    
    public bool StartsWith(string prefix) {
        var node = this;
        foreach(char ch in prefix){
            if(!node.WordMap.ContainsKey(ch)){
                return false;
            }
            node=node.WordMap[ch];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */