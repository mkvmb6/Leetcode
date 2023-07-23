public class Solution {
    public int Compress(char[] chars) {
        int i = 0;
        int j = 0;
        int k = 0;
        var len = chars.Length;
        while(j < len){
            int count = 0;
            while(j < len && chars[i]==chars[j]){
                count++;
                j++;
            }
            chars[k++]=chars[i];
            if(count > 1){
                var strCount = count.ToString();
                foreach(var ch in strCount){
                    chars[k++]=ch;
                }
            }
            i=j;

        }
        return k;
    }
}