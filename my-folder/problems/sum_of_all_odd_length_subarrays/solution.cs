public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        var len = arr.Length;
        var prefixSum = new int[len];
        prefixSum[0] = arr[0];
        for(int i= 1;i< len;i++){
            prefixSum[i] = prefixSum[i-1] + arr[i];
        }
        var sum = 0;
        for(int i=0;i<len;i++){
            for(int j=i;j<len;j+=2){
                sum += prefixSum[j] - (i==0?0:prefixSum[i-1]);
            }
        }
        return sum;
    }
}