public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        var result = new List<IList<int>>{new List<int>()};
        var prevNum = int.MinValue;
        var prevCount = 0;
        foreach(var num in nums){
            var count = result.Count;
            var start = prevNum == num ? prevCount : 0;
            for(int i=start;i<count;i++){
                var newList = result[i].ToList();
                newList.Add(num);
                result.Add(newList);
            }
            
            prevCount = count;
            prevNum = num;
        }
        return result;
    }
}