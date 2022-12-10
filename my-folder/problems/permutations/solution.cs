public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        FindPermutations(0, nums, result);
        return result;
    }

    private void FindPermutations(int swapIndex, int[] nums, IList<IList<int>> result){
        if(swapIndex == nums.Length-1){
            result.Add(nums.ToList());
            return;
        }
        for(int i=swapIndex;i<nums.Length;i++){
            Swap(swapIndex, i, nums);
            FindPermutations(swapIndex+1, nums, result);
            Swap(swapIndex, i, nums);
        }
    }

    private void Swap(int i, int j, int[] items){
        int t = items[i];
        items[i]=items[j];
        items[j]=t;
    }
}