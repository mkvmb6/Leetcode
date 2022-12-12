public class Solution {
    public int ClimbStairs(int n) {
        var cache = new int[n+1];
        return ClimbStairs(n, cache);
    }

    int ClimbStairs(int n, int[] cache){
        if(n<=2){
            return n;
        }
        if(cache[n]!=0){
            return cache[n];
        }
        var res = ClimbStairs(n-1, cache)+ClimbStairs(n-2, cache);
        cache[n] = res;
        return res;
    }
}