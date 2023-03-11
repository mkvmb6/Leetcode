public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int c = 1;
        int k = 1;
        while(c < nums.Length){
            if(nums[c]==nums[c-1]){
                c++;
                continue;
            }
            nums[k++]=nums[c++];            
        }
        return k;
    }
}