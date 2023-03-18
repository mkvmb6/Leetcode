public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        var wordSet = new HashSet<string>(wordList);
        var queue = new Queue<(string word, int length)>();
        queue.Enqueue((beginWord, 1));        
        while(queue.Any()){
            var wordPair = queue.Dequeue();
            if(wordPair.word==endWord){
                return wordPair.length;
            }
            foreach(var nextWord in GetNextWords(wordPair.word, wordSet)){
                queue.Enqueue((nextWord, wordPair.length+1));
            }
        }
        return 0;
    }

    List<string> GetNextWords(string word, HashSet<string> wordSet){
        var nextWords = new List<string>();
        var charArr = word.ToCharArray();
        for(int i=0;i<charArr.Length;i++){
            var org = charArr[i];
            for(int j='a';j<='z';j++){
                charArr[i]=(char)j;
                var nextWord = new String(charArr);
                if(wordSet.Contains(nextWord)){
                    wordSet.Remove(nextWord);
                    nextWords.Add(nextWord);
                }
            }
            charArr[i]=org;
        }
        return nextWords;
    }
}