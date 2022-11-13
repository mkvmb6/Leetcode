public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>{new List<int>()};
        foreach(var num in nums){
            var count = result.Count;
            for(int i=0;i<count;i++){
                var newList = result[i].ToList();
                newList.Add(num);
                result.Add(newList);
            }
        }
        return result;
    }
}