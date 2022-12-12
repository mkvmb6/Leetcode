public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = int.MinValue;
        int maxSumSoFar = 0;
        for(int i=0;i<nums.Length;i++){
            maxSumSoFar += nums[i];
            maxSum = Math.Max(maxSum, maxSumSoFar);
            if(maxSumSoFar < 0){
                maxSumSoFar = 0;
            }
        }
        return maxSum;
    }
}