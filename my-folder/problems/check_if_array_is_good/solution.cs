public class Solution {
    public bool IsGood(int[] nums) {
        var n = nums.Length;
        var map = new Dictionary<int, int>();
        foreach(var num in nums){
            if(!map.ContainsKey(num)){
                map[num] = 0;
            }
            map[num]++;
        }
        for(int i=1;i<n;i++){
            if(!map.ContainsKey(i)){
                return false;
            }
            map[i]--;
        }
        if(!map.ContainsKey(n-1)){
            return false;
        }
        map[n-1]--;
        return map.Values.All(v=>v==0);
    }
}