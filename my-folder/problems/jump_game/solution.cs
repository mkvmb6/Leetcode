public class Solution {
    public bool CanJump(int[] nums) {
        int max = 0;
        for(int i = 0; i<nums.Length-1; i++){
            if(nums[i]==0 && max == 0)
                return false;
            if(nums[i] >= max)
                max = nums[i];
            max--;
        }
        return true;
    }
}