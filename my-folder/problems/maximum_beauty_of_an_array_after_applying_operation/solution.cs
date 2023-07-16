public class Solution {
    public int MaximumBeauty(int[] nums, int k) {
        Array.Sort(nums);
        var len = nums.Length;
        int i = 0;
        int j = 0;
        var maxLen = 0;
        var k2 = 2 * k;
        while(i < len){
            while(j < len && nums[j] - nums[i] <= k2){
                j++;
                maxLen = Math.Max(maxLen, j - i);
            }
            i++;
        }
        return maxLen;
    }
}