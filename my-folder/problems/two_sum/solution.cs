public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var compliments = new Dictionary<int, int>();
        for(int i=0;i<nums.Length;i++){
            if(compliments.ContainsKey(target-nums[i])){
                return new int[]{compliments[target-nums[i]], i};
            }
            else{
                compliments[nums[i]]=i;
            }
        }
        return new int[0];
    }
}