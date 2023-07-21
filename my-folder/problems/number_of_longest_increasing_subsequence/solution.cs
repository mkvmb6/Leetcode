public class Solution {
    public int FindNumberOfLIS(int[] nums) {
        var len = nums.Length;
        var lisLen = new int[len];
        var lisCount = new int[len];
        Array.Fill(lisLen, 1);
        Array.Fill(lisCount, 1);
        for(int i=1;i<len;i++){
            int j = i-1;
            while(j >= 0){
                if(nums[j] < nums[i]){
                    var currentLen = lisLen[j] + 1;
                    if(currentLen > lisLen[i]){
                        lisLen[i] = currentLen;
                        lisCount[i] = lisCount[j];
                    }
                    else if(currentLen == lisLen[i]){
                        lisCount[i]+=lisCount[j];
                    }
                }
                j--;
            }
        }
        int count = lisCount[0];
        int max = lisLen[0];
        int k = 1;
        while(k < len){
            if(lisLen[k] > max){
                max = lisLen[k];
                count = lisCount[k];
            }
            else if(lisLen[k] == max){
                count += lisCount[k];
            }
            k++;
        }
        return count;
    }
}