public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var sb = new StringBuilder();
        for(int i=0;i<strs[0].Length;i++){
            for(int j=1;j<strs.Length;j++){
                if(i >= strs[j].Length || strs[j][i]!=strs[j-1][i]){
                    return sb.ToString();
                }
            }
            sb.Append(strs[0][i]);        
        }
        return sb.ToString();
    }
}