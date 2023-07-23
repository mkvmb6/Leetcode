public class Solution {
    public int LongestOnes(int[] nums, int k) {
        var i = 0;
        var j = 0;
        var flips = 0;
        var maxSize = 0;
        var size = 0;
        var len = nums.Length;
        while(j < len){
            while(j < len && (nums[j] == 1 || flips < k)){
                if(nums[j] == 0){
                    flips++;
                }
                j++;
            }
            maxSize = Math.Max(maxSize, j - i);
            while(i < len && nums[i]!=0){
                i++;
            }
            i++;
            if(flips==0){
                j++;
            }
            else{
                flips--;
            }
        }
        return maxSize;
    }
}