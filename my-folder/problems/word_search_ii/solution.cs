public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        var trie = new Trie();
        foreach(var word in words){
            trie.Insert(word);
        }
        
        var result = new HashSet<string>();
        var rows = board.Length;
        var cols = board[0].Length;
        var visited = new HashSet<(int, int)>();
        for(int i=0;i<rows;i++){
            for(int j=0;j<cols;j++){
                SearchWord(board, i, j, trie, visited, result, string.Empty);
            }
        }
        
        return result.ToList();
    }
    
    private void SearchWord(char[][] board, int row, int col, Trie node, HashSet<(int, int)> visited, HashSet<string> result, string word){
        var rows = board.Length;
        var cols = board[0].Length;
        if(row<0 || col<0 || row>=rows || col >=cols || visited.Contains((row, col)) || !node.WordMap.ContainsKey(board[row][col])){
            return;
        }
        visited.Add((row,col));
        word+=board[row][col];
        node=node.WordMap[board[row][col]];
        if(node.EndsHere){
            result.Add(word);
        }
        
        SearchWord(board, row+1, col, node, visited, result, word);
        SearchWord(board, row, col+1, node, visited, result, word);
        SearchWord(board, row, col-1, node, visited, result, word);
        SearchWord(board, row-1, col, node, visited, result, word);
        
        visited.Remove((row,col));
    }
}

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
}