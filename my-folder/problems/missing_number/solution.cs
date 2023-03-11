public class Solution {
    public int MissingNumber(int[] nums) {
        var sum  = 0;
        foreach(var num in nums){
            sum+=num;
        }
        var len = nums.Length;
        var expected = (len * (len+1))/2;
        return expected - sum;
    }
}