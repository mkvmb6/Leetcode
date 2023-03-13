public class Solution {
    public void NextPermutation(int[] nums) {
        var len = nums.Length;
        var i = len-2;
        var index1 = -1;
        while(i >= 0){
            if(nums[i] < nums[i+1]){
                index1 = i;
                break;
            }
            i--;
        }
        var index2= len - 1;
        if(index1 != -1){
            i = len-1;
            while(i >= 0){
                if(nums[i] > nums[index1]){
                    index2 = i;
                    break;
                }
                i--;
            }
            Swap(index1, index2, nums);
        }
        index1++;
        index2 = len -1;
        while(index1<index2){
            Swap(index1++, index2--, nums);
        }
    }

    void Swap(int index1, int index2, int[] nums){
        var temp = nums[index1];
        nums[index1] = nums[index2];
        nums[index2] =  temp;
    }
}