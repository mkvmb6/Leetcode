public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var i = 0;
        var j = 0;
        var k = 0;
        var flips = 0;
        var maxSize = 0;
        var size = 0;
        var len = nums.Length;
        while(j < len){
            while(j < len && (nums[j] == 1 || flips == 0)){
                if(nums[j] == 0){
                    flips = 1;
                    k = j;
                }
                j++;
            }
            maxSize = Math.Max(maxSize, j - i);
            i = k + 1;
            flips = 0;
        }
        return maxSize;
    }
}