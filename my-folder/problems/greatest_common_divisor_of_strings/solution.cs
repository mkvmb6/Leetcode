public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if(str1+str2!=str2+str1){
            return string.Empty;
        }
        var gcd = GetGCD(str1.Length, str2.Length);
        return str1.Substring(0, gcd);
    }

    int GetGCD(int x, int y){
        if(y == 0){
            return x;
        }
        return GetGCD(y, x % y);
    }
}