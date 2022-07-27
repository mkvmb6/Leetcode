public class Solution {
    public long SubArrayRanges(int[] nums) {
        long sum = 0;
        var len = nums.Length;
        for(int i=0;i<len;i++){
            int min = int.MaxValue;
            int max = int.MinValue;
            for(int j=i;j<len;j++){
                min=Math.Min(min, nums[j]);
                max=Math.Max(max, nums[j]);
                sum+=max - min;
            }
        }
        return sum;
    }
}