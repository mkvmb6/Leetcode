public class Solution {
    public void MoveZeroes(int[] nums) {
        int left = 0;
        int right = 0;
        while(left < nums.Length && right < nums.Length){
            if(nums[left]!=0){
                left++;
                continue;
            }
            right=Math.Max(left, right);
            if(nums[right]==0){
                right++;
                continue;
            }
            nums[left]=nums[right];
            nums[right]=0;
        }        
    }
}