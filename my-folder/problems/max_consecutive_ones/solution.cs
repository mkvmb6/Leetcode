public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var max = 0;
        var count = 0;
        foreach(var num in nums){
            if(num == 1){
                count++;
                continue;
            }
            max = Math.Max(max, count);
            count = 0;
        }
        max = Math.Max(max, count);
        return max;
    }
}