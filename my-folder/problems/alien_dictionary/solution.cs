public class Solution {
    bool invalidDictionary = false;
    public string AlienOrder(string[] words) {
        invalidDictionary = false;
        var len = words.Length;
        var inDegree = new int[26];
        for(int i=0;i<26;i++){
            inDegree[i]=-1;
        }
        var graph = new Dictionary<int, HashSet<int>>();
        SetInDegreeToZero(words[0], inDegree);
        for(int i=1;i<len;i++){
            SetInDegreeToZero(words[i], inDegree);
            if(!MakeGraphFromComparision(words[i-1], words[i], graph)){
                return string.Empty;
            }
        }
        var totalChars = inDegree.Count(i=>i==0);
        var result = new StringBuilder();
        foreach(var kvp in graph){
            foreach(var child in kvp.Value){
                inDegree[child]++;;
            }
        }
        var queue = new Queue<int>();
        for(int i=0;i<26;i++){
            if(inDegree[i]==0){
                queue.Enqueue(i);
            }
        }
        while(queue.Any()){
            var item = queue.Dequeue();
            if(graph.ContainsKey(item)){
                foreach(var child in graph[item]){
                    inDegree[child]--;
                    if(inDegree[child]==0){
                        queue.Enqueue(child);
                    }
                }
            }            
            result.Append((char)(item+'a'));
        }
        var alienOrder =  result.ToString();
        return alienOrder.Length == totalChars ? alienOrder : string.Empty;

    }

    void SetInDegreeToZero(string word, int[] inDegree){
        foreach(var ch in word){
            inDegree[ch - 'a']=0;
        }
    }

    bool MakeGraphFromComparision(string word1, string word2, Dictionary<int, HashSet<int>> graph){
        int i = 0;
        bool linkAdded = false;
        while(i < word1.Length && i < word2.Length){
            if(word1[i]==word2[i]){
                i++;
                continue;
            }
            var node1 = word1[i]-'a';
            var node2 = word2[i]-'a';
            if(!graph.ContainsKey(node1)){
                graph[node1]=new HashSet<int>();
            }
            graph[node1].Add(node2);
            linkAdded = true;
            break;
        }

        if(!linkAdded && word1.Length!=word2.Length){
            if(word1.Length > word2.Length){
                return false;
            }
            var n1 = word1[i-1]-'a';
            var n2 = word2[i]-'a';
            if(!graph.ContainsKey(n1)){
                graph[n1]=new HashSet<int>();
            }
            graph[n1].Add(n2);
        }
        return true;

    }
}