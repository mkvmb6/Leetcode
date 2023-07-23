public class Solution {
    public int PivotIndex(int[] nums) {
        var sum = nums.Sum();
        var leftSum = 0;
        for(int i=0;i<nums.Length;i++){
            var rightSum = sum -leftSum - nums[i];
            if(leftSum == rightSum){
                return i;
            }
            leftSum+=nums[i];
        }
        return -1;
    }
}