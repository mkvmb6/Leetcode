public class Solution {
    public int[] SumZero(int n) {
        var result = new int[n];
        int start = 0;
        if(n%2!=0){
            start++;
        }
        int seed=1;
        for(int i=start;i<n;i+=2){
            result[i]=seed;
            result[i+1]= -seed;
            seed++;
        }
        return result;
    }
}