public class WordDictionary {
    
    public Dictionary<char, WordDictionary> WordMap{get;set;}
    public bool EndsHere{get;set;}
    
    public WordDictionary() {
        WordMap = new Dictionary<char, WordDictionary>();
    }
    
    public void AddWord(string word) {
        var node = this;
        foreach(char ch in word){
            if(!node.WordMap.ContainsKey(ch)){
                node.WordMap[ch]=new WordDictionary();
            }
            node=node.WordMap[ch];
        }
        node.EndsHere=true;
    }
    
    public bool Search(string word) {
        return Search(word, 0, this);
    }
    
    private bool Search(string word, int start, WordDictionary node){
        for(int i=start;i<word.Length;i++){
            var ch = word[i];
            if(ch=='.'){
                foreach(var kvp in node.WordMap){
                    if(kvp.Value.Search(word, i+1, kvp.Value)){
                        return true;
                    }
                }
                return false;
            }
            else if(!node.WordMap.ContainsKey(ch)){
                return false;
            }
            else{
                node=node.WordMap[ch];
            }
        }
        return node.EndsHere;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */