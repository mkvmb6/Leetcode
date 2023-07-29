public class Solution {
    public double SoupServings(int n) {
        if(n > 5000) {
            return 1;
        }
        var cache = new double[n+1, n+1];
        return GetProbability(n, n, cache);
    }

    double GetProbability(int a, int b, double[,] cache) {
        if(a <= 0 && b <= 0) {
            return 0.5;
        }
        if(a <= 0) {
            return 1;
        }
        if(b <= 0) {
            return 0;
        }
        
        if(cache[a, b] != 0) {
            return cache[a, b];
        }

        var p1 = GetProbability(a - 100, b, cache);
        var p2 = GetProbability(a - 75, b - 25, cache);
        var p3 = GetProbability(a - 50, b - 50, cache);
        var p4 = GetProbability(a - 25, b - 75, cache);
        return cache[a, b] = (p1+p2+p3+p4)*0.25;
    }
}