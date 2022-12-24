public class Solution {
    public int NumTilings(int n) {
        var cache1 = new Dictionary<int, long>();
        var cache2 = new Dictionary<int, long>();
        return (int)Fun1(n, cache1, cache2);
    }

    long Fun1(int n, Dictionary<int, long> cache1, Dictionary<int, long> cache2){
        if(cache1.ContainsKey(n)){
            return cache1[n];
        }
        if(n<=2){
            return n;
        }
        return cache1[n] = (Fun1(n-1, cache1, cache2) + Fun1(n-2, cache1, cache2) + 2*Fun2(n-1, cache1, cache2))%1000000007;
    }

    long Fun2(int n, Dictionary<int, long> cache1, Dictionary<int, long> cache2){
        if(cache2.ContainsKey(n)){
            return cache2[n];
        }
        if(n==2){
            return 1;
        }
        return cache2[n] = (Fun2(n-1, cache1, cache2) + Fun1(n-2, cache1, cache2))%1000000007;
    }
}