public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        var first = int.MaxValue;
        var second = int.MaxValue;
        foreach(var num in nums){
            if(num < first){
                first = num;
            }
            else if(num > first && num < second){
                second = num;
            }
            else if(num > second){
                return true;
            }
        }
        return false;
    }
}