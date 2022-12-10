public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var result = new List<IList<int>>();
        Array.Sort(candidates);
        FindCombinations(0, candidates, target, new List<int>(), result);
        return result;
    }

    private void FindCombinations(int index, int[] candidates, int target, List<int> pickedItems, IList<IList<int>> result){
        if(target==0){
            result.Add(pickedItems.ToList());
            return;
        }
        if(index == candidates.Length || target<0){
            return;
        }
        pickedItems.Add(candidates[index]);
        FindCombinations(index+1, candidates, target-candidates[index], pickedItems, result);
        pickedItems.Remove(candidates[index]);
        while(index < candidates.Length-1 && candidates[index]==candidates[index+1]){
            index++;
        }
        FindCombinations(index+1, candidates, target, pickedItems, result);
    }
}