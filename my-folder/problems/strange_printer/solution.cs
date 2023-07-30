public class Solution {
    public int StrangePrinter(string s) {
        var len = s.Length;
        var cache = new int[len + 1, len + 1];
        return FindMinTurn(0, len - 1, s, cache);
    }

    int FindMinTurn(int left, int right, string s, int[,] cache) {
        if(left == right) {
            return 1;
        }
        
        if(left > right) {
            return 0;
        }

        if(cache[left, right] != 0) {
            return cache[left, right];
        }

        var i = left + 1;
        while(i <= right && s[i]==s[left]) {
            i++;
        }

        var basic = 1 + FindMinTurn(i, right, s, cache);
        var j = i;
        var optm = int.MaxValue;
        while(j <= right) {
            if(s[j] == s[left]) {
                optm = Math.Min(optm, FindMinTurn(i, j-1, s, cache) + FindMinTurn(j, right, s, cache));
            }
            j++;
        }
        return cache[left, right] = Math.Min(basic, optm);
    }
}