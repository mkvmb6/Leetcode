public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var sb = new StringBuilder();
        var left = 0;
        var right = 0;
        while(left<word1.Length && right < word2.Length){
            sb.Append(word1[left++]+""+word2[right++]);
        }
        if(left < word1.Length){
            sb.Append(word1.Substring(left));
        }
        if(right < word2.Length){
            sb.Append(word2.Substring(right));
        }
        return sb.ToString();
    }
}