public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);
        var result1 = new HashSet<int>();
        var result2 = new HashSet<int>();
        foreach(var num in nums1){
            if(!set2.Contains(num)){
                result1.Add(num);
            }
        }

        foreach(var num in nums2){
            if(!set1.Contains(num)){
                result2.Add(num);
            }
        }
        return new List<IList<int>>{result1.ToList(), result2.ToList()};

    }
}