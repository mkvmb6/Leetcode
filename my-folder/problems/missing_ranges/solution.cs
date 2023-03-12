public class Solution {
    public IList<string> FindMissingRanges(int[] nums, int lower, int upper) {
        var result = new List<string>();
        var start = lower;
        var range = "";
        foreach(var num in nums){
            if(num==start){
                start++;
                continue;
            }
            if(num-start==1){
                result.Add(start.ToString());
            }
            else{
                result.Add($"{start}->{num-1}");
            }
            start=num+1;
        }
        if(start==upper){
            result.Add(start.ToString());
        }
        else if(start < upper){
            result.Add($"{start}->{upper}");
        }
        return result;
    }
}