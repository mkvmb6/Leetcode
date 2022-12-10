public class Solution {
    public int FindDuplicate(int[] nums) {
        var slow = 0;
        var fast = 0;
        do{
            slow=nums[slow];
            fast=nums[nums[fast]];
        }
        while(slow!=fast);
        fast = 0;
        while(slow!=fast){
            slow=nums[slow];
            fast=nums[fast];
        }
        return fast;
    }
}