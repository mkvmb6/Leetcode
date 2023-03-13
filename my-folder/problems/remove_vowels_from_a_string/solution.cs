public class Solution {
    public string RemoveVowels(string s) {
        var sb = new StringBuilder();
        var set = new HashSet<char>{'a', 'e', 'i', 'o', 'u'};
        foreach(var ch in s){
            if(!set.Contains(ch)){
                sb.Append(ch);
            }
        }
        return sb.ToString();
    }
}