public class Solution {
    public long PutMarbles(int[] weights, int k) {
        var len = weights.Length;
        var pairs = new int[len - 1];
        for(int i=0;i<len-1;i++){
            pairs[i]=weights[i]+weights[i+1];
        }
        Array.Sort(pairs);
        long min = 0;
        long max = 0;
        for(int i=0;i<k-1;i++){
            min += pairs[i];
            max += pairs[len - i - 2];
        }
        return max - min;
    }
}