public class Solution {
    public void ReverseString(char[] s) {
        var left = 0;
        var right = s.Length - 1;
        while(left<right){
            var t = s[left];
            s[left]=s[right];
            s[right]=t;
            left++;
            right--;
        }
    }
}