public class Solution {
    public int MaxVowels(string s, int k) {
        var count = 0;
        int i = 0;
        var len = s.Length;
        int j = 0;
        var maxCount = 0;
        while(j < len){
            if(j - i + 1 <= k){
                if(IsVowel(s[j])){
                    count++;
                    maxCount = count;
                }
                j++;
                continue;
            }
            if(IsVowel(s[i])){
                count--;
            }
            i++;
            if(IsVowel(s[j])){
                count++;
                maxCount = Math.Max(maxCount, count);
            }
            j++;
        }
        return maxCount;
    }

    bool IsVowel(char ch){
        return ch == 'a' ||ch == 'o' ||ch == 'i' ||ch == 'e' ||ch == 'u';
    }
}