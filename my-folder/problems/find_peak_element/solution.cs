public class Solution {
    public int FindPeakElement(int[] nums) {
        if(nums.Length == 1){
            return 0;
        }
        if(nums[0] > nums[1]){
            return 0;
        }
        var end = nums.Length - 1;
        if(nums[end] > nums[end-1]){
            return end;
        }
        int start = 0;
        while(start<=end){
            var mid = start + (end - start)/2;
            if(nums[mid]>nums[mid+1] && nums[mid]>nums[mid-1]){
                return mid;
            }
            else if(nums[mid] > nums[mid+1]){
                end = mid - 1;
            }
            else{
                start = mid + 1;
            }
        }
        return -1;
    }
}