public class Solution {
    public int Jump(int[] nums) {
        var cache = new Dictionary<int, int>();
        return Jump(nums, 0, cache);
    }
    
    int Jump(int[] nums, int current, Dictionary<int, int> cache){
        if(current >= nums.Length-1){
            return 0;
        }
        
        if(cache.ContainsKey(current)){
            return cache[current];
        }
        
        int jumps = int.MaxValue;
        for(int i=1;i<=nums[current];i++){
            int currentJumps = Jump(nums, current+i, cache);
            if(currentJumps!=int.MaxValue){
                jumps=Math.Min(jumps, 1+currentJumps);
            }
        }
        cache[current]=jumps;
        return jumps;
    }
}

