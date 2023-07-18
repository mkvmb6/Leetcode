public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        var left = 0;
        var right = 0;
        var len = nums.Length;
        double maxSum = 0;
        double sum = 0;
        while(right < len){
            if(right - left + 1 <= k){
                sum += nums[right];
                right++;
                maxSum = sum;
                continue;
            }

            sum -= nums[left];
            left++;
            sum += nums[right];            
            maxSum = Math.Max(maxSum, sum);
            right++;
        }
        return maxSum / k;
    }
}