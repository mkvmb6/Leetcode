public class Solution {
    public int NumSquares(int n) {
        return GetMinSquares(n, new int[n+1]);
    }

    int GetMinSquares(int n, int[] cache) {
        if(cache[n] != 0) {
            return cache[n];
        }

        if(n <= 0) {
            return 0;
        }

        var minSquare = int.MaxValue;
        for(int i=1;i*i<=n;i++) {
            minSquare = Math.Min(minSquare, 1 + GetMinSquares(n - (i*i), cache));
        }
        return cache[n] = minSquare;
    }
}