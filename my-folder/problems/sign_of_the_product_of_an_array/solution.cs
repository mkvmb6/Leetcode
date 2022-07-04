public class Solution {
    public int ArraySign(int[] nums) {
        bool sign = false;
        foreach(var num in nums){
            if(num == 0){
                return 0;
            }
            if(num < 0){
                sign=!sign;
            }
        }
        return sign?-1:1;
    }
}