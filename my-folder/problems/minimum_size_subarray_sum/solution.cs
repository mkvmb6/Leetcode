public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        var i = 0;
        var j = 0;
        var len = nums.Length;
        var sum = 0;
        var minWindow = int.MaxValue;
        while(i < len){
            while(j < len && sum < target){
                sum += nums[j];
                j++;
            }
            if(sum >= target){
                minWindow = Math.Min(minWindow, j - i);
                sum -= nums[i];
                i++;
            }
            else{
                break;
            }
        }
        return minWindow == int.MaxValue ? 0 : minWindow;
    }
}