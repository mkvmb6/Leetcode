public class Solution {
    public string LongestPalindrome(string s) {
        if(string.IsNullOrEmpty(s)){
            return string.Empty;
        }
        int start = 0, end = 0;
        for(int i=0;i<s.Length;i++){
            var len1 = GetPalindromicLengthFromCenter(s, i, i);
            var len2 = GetPalindromicLengthFromCenter(s, i, i+1);
            var len = Math.Max(len1, len2);
            if(len > end - start){
                start = i - (len-1)/2;
                end = i + len/2;
            }
        }
        return s.Substring(start, end-start+1);
    }
    
    int GetPalindromicLengthFromCenter(string s, int left, int right){
        var len = s.Length;
        while(left >= 0 && right < len && s[left]==s[right]){
            left--;
            right++;
        }
        return right - left - 1;
    }
}