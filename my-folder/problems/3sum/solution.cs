public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        Array.Sort(nums);
        var result = new List<IList<int>>();
        var len = nums.Length;
        for(int i=0;i<len-2;i++){
            if(i!=0 && nums[i]==nums[i-1]){
                continue;
            }
            var left=i+1;
            var right=len-1;
            while(left<right){
                var sum = nums[i]+nums[left]+nums[right];
                if(sum==0){
                    result.Add(new List<int>{nums[i],nums[left],nums[right]});
                    left++;
                    while(left<right && nums[left-1]==nums[left]){
                        left++;
                    }
                }
                else if(sum<0){
                    left++;
                }else{
                    right--;
                }
            }
        }
        return result;
    }
}