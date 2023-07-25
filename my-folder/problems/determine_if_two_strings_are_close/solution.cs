public class Solution {
    public bool CloseStrings(string word1, string word2) {
        if(word1.Length != word2.Length){
            return false;
        }

        var map1 = new Dictionary<char, int>();
        foreach(var ch in word1) {
            map1[ch] = map1.GetValueOrDefault(ch, 0) + 1;
        }

        var map2 = new Dictionary<char, int>();
        foreach(var ch in word2) {
            map2[ch] = map2.GetValueOrDefault(ch, 0) + 1;
        }
        var keys1 = map1.Keys.ToList();
        var keys2 = map2.Keys.ToList();
        keys1.Sort();
        keys2.Sort();
        if(!keys1.SequenceEqual(keys2)){
            return false;
        }
        var freq1 = map1.Values.ToList();
        var freq2 = map2.Values.ToList();
        freq1.Sort();
        freq2.Sort();
        return freq1.SequenceEqual(freq2);
    }
}