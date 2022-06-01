public class Solution {
    public int[] RunningSum(int[] nums) {
        var res = new int[nums.Length];
        int sum = 0;
        int i = 0;
        foreach(var num in nums){
            sum += num;
            res[i++]=sum;
        }
        return res;
    }
}