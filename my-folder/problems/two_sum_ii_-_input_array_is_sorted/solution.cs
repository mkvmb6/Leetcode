public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;
        while(left < right){
            var sum = numbers[left]+numbers[right];
            if(sum==target){
                return new int[]{left+1, right+1};
            }
            else if(sum > target){
                right--;
            }
            else{
                left++;
            }
        }
        return null;
    }
}