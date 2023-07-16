public class Solution {
    public int SumOfSquares(int[] nums) {
        var sum = 0;
        var len = nums.Length;
        for(int i=0;i<len;i++){
            if(len % (i+1) == 0){
                sum += nums[i]*nums[i];
            }
        }
        return sum;
    }
}