public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var len = nums.Length;
        var result = new int[len];
        result[0]=1;
        for(int i=1;i<len;i++){
            result[i]=result[i-1]*nums[i-1];
        }
        var mul = 1;
        for(int i=len-2;i>=0;i--){
            mul*=nums[i+1];
            result[i]=result[i]*mul;
        }
        return result;
    }
}


//1, 2, 3, 4
//1, 1, 2, 6 
//24 12 8, 6



//2, 3, 8, 3
//         