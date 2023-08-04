public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var cache = new bool?[s.Length];
        var wordSet = new HashSet<string>(wordDict);
        return CanBeBroken(s, wordSet, 0, cache);
    }

    bool CanBeBroken(string s, HashSet<string> wordSet, int idx, bool?[] cache) {
        if(idx >= s.Length) {
            return true;
        }

        if(cache[idx].HasValue) {
            return cache[idx].Value;
        }

        for(int i=idx;i<s.Length;i++) {
            var subStr = s.Substring(idx, i - idx + 1);
            if(wordSet.Contains(subStr) && CanBeBroken(s, wordSet, i + 1, cache)){
                cache[idx] = true;
                return true;
            }
        }
        cache[idx] = false;
        return false;
    }
}