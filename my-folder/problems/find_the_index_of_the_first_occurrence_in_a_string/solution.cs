public class Solution {
    public int StrStr(string haystack, string needle) {
        if(haystack.Length < needle.Length || needle.Length == 0){
            return -1;
        }
        int h = 0;
        while(h < haystack.Length){
            int n = 0;
            while(n < needle.Length && h+n < haystack.Length){
                if(haystack[h+n]!=needle[n]){
                    break;
                }
                n++;
            }
            if(n==needle.Length){
                return h;
            }
            h++;
        }
        return -1;
    }
}