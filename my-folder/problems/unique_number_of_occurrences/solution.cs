public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var set = new Dictionary<int, int>();
        foreach(var item in arr){
            if(!set.ContainsKey(item)){
                set[item] = 0;
            }
            set[item]++;
        }
        var set2 = new HashSet<int>(set.Values);
        return set.Count == set2.Count;
    }
}