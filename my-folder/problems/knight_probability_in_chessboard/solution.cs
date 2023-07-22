public class Solution {
    public double KnightProbability(int n, int k, int row, int column) {
        var cache = new Dictionary<string, double>();
        return TraverseKnight(n, k, row, column, cache);
    }

    double TraverseKnight(int n, int k, int row, int column, Dictionary<string, double> cache){
        var key = $"{k}-{row}-{column}";
        if(cache.ContainsKey(key)){
            return cache[key];
        }
        if(row < 0 || column < 0 || row >= n || column >= n){
            return 0;
        }
        if(k == 0){
            return 1;
        }
        double sum = 0;
        sum += TraverseKnight(n, k - 1, row - 2, column + 1, cache);
        sum += TraverseKnight(n, k - 1, row - 1, column + 2, cache);
        sum += TraverseKnight(n, k - 1, row + 1, column + 2, cache);
        sum += TraverseKnight(n, k - 1, row + 2, column + 1, cache);
        sum += TraverseKnight(n, k - 1, row + 2, column - 1, cache);
        sum += TraverseKnight(n, k - 1, row + 1, column - 2, cache);
        sum += TraverseKnight(n, k - 1, row - 1, column - 2, cache);
        sum += TraverseKnight(n, k - 1, row - 2, column - 1, cache);
        var result = sum / 8;
        cache[key] = result;
        return result;
    }
}