public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length-1;
        var len = s.Length;
        while(left<right){
            while(left<len && (!char.IsDigit(s[left]) && !char.IsLetter(s[left]))){
                left++;
            }
            while(right>=0 && (!char.IsDigit(s[right]) && !char.IsLetter(s[right]))){
                right--;
            }
            if(left < right){
                var lc = char.ToLower(s[left]);
                var rc = char.ToLower(s[right]);
                if(lc!=rc)
                    return false;
                left++;
                right--;
            }
        }
        return true;
    }
}