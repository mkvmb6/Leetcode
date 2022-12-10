public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var nums = new int[]{1,2,3,4,5,6,7,8,9};
        var result = new List<IList<int>>();
        FindCombinations(0, nums, n, k, new List<int>(), result);
        return result;
    }

    private void FindCombinations(int index, int[] nums, int target, int combLen, List<int> pickedItems, IList<IList<int>> result){
        if(target==0){
            if(pickedItems.Count==combLen){
                result.Add(pickedItems.ToList());
            }
            return;
        }
        if(index == nums.Length || target<0){
            return;
        }
        pickedItems.Add(nums[index]);
        FindCombinations(index+1, nums, target-nums[index], combLen, pickedItems, result);
        pickedItems.Remove(nums[index]);
        FindCombinations(index+1, nums, target, combLen, pickedItems, result);
    }
}