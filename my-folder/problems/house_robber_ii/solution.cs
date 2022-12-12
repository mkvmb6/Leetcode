public class Solution {
    public int Rob(int[] nums) {
        var len = nums.Length;
        if(len==1){
            return nums[0];
        }
        var cache = new int[len+1];
        for(int i=0;i<len;i++){
            cache[i]=-1;
        }
        var rob1 = FindMaxAmount(len-1, nums, cache, 1);
        for(int i=0;i<len;i++){
            cache[i]=-1;
        }
        var rob2 = FindMaxAmount(len-2, nums, cache, 0);
        return Math.Max(rob1, rob2);
    }

    int FindMaxAmount(int n, int[] nums, int[] cache, int limit){
        if(n<limit){
            return 0;
        }
        if(cache[n]!=-1){
            return cache[n];
        }
        var res = Math.Max(nums[n]+FindMaxAmount(n-2, nums, cache, limit), FindMaxAmount(n-1, nums, cache, limit));
        cache[n]=res;
        return res;
    }
}