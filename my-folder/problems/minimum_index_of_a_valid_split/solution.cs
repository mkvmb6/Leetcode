public class Solution {
    public int MinimumIndex(IList<int> nums) {
        var map = new Dictionary<int, int>();
        var maxIndex = -1;
        var maxElement = -1;
        var maxCount = -1;
        var len = nums.Count;
        for(int i=0;i<len;i++){
            var num = nums[i];
            map[nums[i]] = map.GetValueOrDefault(nums[i], 0) + 1;
            if(map[num] > maxCount){
                maxCount = map[num];
                maxIndex = i;
                maxElement = num;
            }
        }
        
        var countAt = new int[len];
        if(nums[0]==maxElement){
            countAt[0] = 1;
        }
        for(int i=1;i<len;i++){
            if(nums[i]==maxElement){
                countAt[i] = countAt[i-1]+1;
            }
            else{
                countAt[i]=countAt[i-1];
            }
        }
        
        var countAt2 = new int[len];
        if(nums[len-1]==maxElement){
            countAt2[len-1] = 1;
        }
        for(int i=len-2;i>=0;i--){
            if(nums[i]==maxElement){
                countAt2[i] = countAt2[i+1]+1;
            }
            else{
                countAt2[i]=countAt2[i+1];
            }
        }
        
        
        for(int i=1;i<len;i++){
            var left = i;
            var right = len - i;
            if(countAt[i-1]*2 > left && countAt2[i] *2 > right){
                return i - 1;
            }
        }
        return -1;
        
        
        
    }
}