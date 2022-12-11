public class Solution {
    public int Fib(int n) {
        var cache = new Dictionary<int, int>();
        return Fib(n, cache);
    }

    int Fib(int n, Dictionary<int, int> cache){
        if(n<=1){
            return n;
        }
        if(cache.ContainsKey(n)){
            return cache[n];
        }
        var res = Fib(n-1)+Fib(n-2);
        cache[n]=res;
        return res;
    }
}