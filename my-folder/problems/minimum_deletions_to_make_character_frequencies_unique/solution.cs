
public class Solution {
    public int MinDeletions(string s) {
        var freqMap = new Dictionary<char, int>();
        foreach(var c in s){
            if(freqMap.ContainsKey(c)){
                freqMap[c]++;
            }
            else{
                freqMap[c]=1;
            }
        }
        var sortedFreq = freqMap.OrderByDescending(f=>f.Value);
        var seenFreq = new HashSet<int>();
        var deletions = 0;
        foreach(var item in sortedFreq){
            var freq = item.Value;
            while(seenFreq.Contains(freq)){
                freq--;
                deletions++;
            }
            if(freq!=0)
                seenFreq.Add(freq);
        }
        return deletions;
    }
}