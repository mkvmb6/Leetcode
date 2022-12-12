public class Solution {
    public int Rob(int[] nums) {
        var len = nums.Length;
        var cache = new int[len+1];
        for(int i=0;i<len;i++){
            cache[i]=-1;
        }
        return FindMaxAmount(len-1, nums, cache);
    }

    int FindMaxAmount(int n, int[] nums, int[] cache){
        if(n<0){
            return 0;
        }
        if(cache[n]!=-1){
            return cache[n];
        }
        var res = Math.Max(nums[n]+FindMaxAmount(n-2, nums, cache), FindMaxAmount(n-1, nums, cache));
        cache[n]=res;
        return res;
    }
}