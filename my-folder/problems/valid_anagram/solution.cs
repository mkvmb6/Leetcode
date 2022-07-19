public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }
        var charMap = new Dictionary<char, int>();
        
        foreach(var ch in s){
            charMap[ch]=charMap.TryGetValue(ch, out int val)?val+1:1;
        }
        foreach(var ch in t){
            charMap[ch]=charMap.TryGetValue(ch, out int val)?val-1:-1;
            if(charMap[ch]<0){
                return false;
            }
        }
        return true;
    }
}