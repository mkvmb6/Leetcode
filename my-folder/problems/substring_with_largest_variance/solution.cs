public class Solution {
    public int LargestVariance(string s) {
        var charSet = new HashSet<char>(s);
        var result = 0;
        foreach(var ch1 in charSet){
            foreach(var ch2 in charSet){
                if(ch1==ch2){
                    continue;
                }
                var f1 = 0;
                var f2 = 0;
                var seen = false;
                foreach(var chs in s){
                    if(chs == ch1){
                        f1++;
                    }
                    if(chs == ch2){
                        f2++;
                    }
                    if(f2 > f1){
                        f1 = 0;
                        f2 = 0;
                        seen = true;
                    }
                    if(f2 != 0){
                        result = Math.Max(result, f1 - f2);
                    }
                    else if(seen){
                        result = Math.Max(result, f1 - 1);
                    }
                }
            }
        }
        return result;
    }
}