public class Solution {
    public int[] AnswerQueries(int[] nums, int[] queries) {
        Array.Sort(nums);
        var len = nums.Length;
        var pfSum = new int[len];
        pfSum[0]=nums[0];
        for(int i=1;i<len;i++){
            pfSum[i]=pfSum[i-1]+nums[i];
        }
        var result = new int[queries.Length];
        for(int i=0;i<queries.Length;i++){
            result[i]=FindMaxLen(pfSum, queries[i]);
        }
        return result;
    }

    int FindMaxLen(int[] pfSum, int query){
        int start = 0;
        int end = pfSum.Length - 1;
        int mid = -1;
        while(start <= end){
            mid = start + (end-start)/2;
            if(pfSum[mid]==query){
                return mid+1;
            }
            if(pfSum[mid] < query){
                start = mid + 1;    
            }
            else{
                end = mid - 1;
            }
        }
        if(pfSum[mid]>query){
            mid--;
        }
        return mid + 1;
    }
}