public class Solution {
    public void SortColors(int[] nums) {
        var len = nums.Length;
        int left = 0;
        int curr = 0;
        int right = len - 1;

        while(curr <= right){
            if(nums[curr]==0){
                Swap(left++, curr++, nums);
            }
            else if(nums[curr] == 2){
                Swap(curr, right--, nums);
            }
            else{
                curr++;
            }
        }
    }

    void Swap(int index1, int index2, int[] nums){
        var temp = nums[index1];
        nums[index1] = nums[index2];
        nums[index2] = temp;
    }
}

/*
0   1   0   2   1   0
r,w                 b

0   1   1   0   1   0   0

*/