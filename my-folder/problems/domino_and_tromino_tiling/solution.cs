public class Solution {
    public int NumTilings(int n) {
         var cache = new int[n+1];
         return FindWays(n, cache);
    }

    int FindWays(int n, int[] cache) {
        if(n <= 2) {
            return n;
        }
        if(n == 3) {
            return 5;
        }
        if(cache[n] != 0) {
            return cache[n];
        }
        var mod = 1000000007;
        return cache[n] = (2*FindWays(n - 1, cache)%mod + FindWays(n - 3, cache)%mod)%mod;
    }
}