public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        var cache = new int[target + 1];
        Array.Fill(cache, -1);
        var result = FindCombinations(nums, target, cache);
        return result;
    }

    private int FindCombinations(int[] nums, int target, int[] cache){
        if(target == 0){
            return 1;
        }
        if(cache[target] != -1) {
            return cache[target];
        }
        int result = 0;
        for(int i=0;i<nums.Length;i++) {
            if(target - nums[i] < 0) {
                continue;
            }
            result += FindCombinations(nums, target - nums[i], cache);
        }
        return cache[target] = result;
    }
}