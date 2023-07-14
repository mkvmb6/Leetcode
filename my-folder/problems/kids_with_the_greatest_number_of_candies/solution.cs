public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var max = candies.Max();
        var result = new List<bool>();
        foreach(var candy in candies){
            result.Add(candy+extraCandies >= max);
        }
        return result;
    }
}