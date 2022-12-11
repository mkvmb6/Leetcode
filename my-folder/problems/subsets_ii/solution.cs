public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        var result = new List<IList<int>>();
        Array.Sort(nums);    
        FindSubsets(0, nums, new List<int>(), result);
        return result;
    }

    void FindSubsets(int index, int[] nums, IList<int> pickedItems, IList<IList<int>> result){
        if(index==nums.Length){
            result.Add(pickedItems.ToList());
            return;
        }
        pickedItems.Add(nums[index]);
        FindSubsets(index+1, nums, pickedItems, result);
        pickedItems.Remove(nums[index]);
        while(index<nums.Length-1 && nums[index]==nums[index+1]){
            index++;
        }
        FindSubsets(index+1, nums, pickedItems, result);
    }
}