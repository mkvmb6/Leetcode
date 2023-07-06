public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        var start = -1;
        var end = -1;
        long count = 0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==0){
                if(start==-1){
                    start = i;
                }
                end = i;
            }
            else{
                if(start!=-1){
                    long n = end - start + 1;
                    count += n*(n+1)/2;
                }
                start = -1;
                end = -1;
            }
        }
        if(start!=-1){
            long n = end - start + 1;
            count += n*(n+1)/2;
        }
        return count;
    }
}