public class Solution {
    public int MaxLength(IList<string> arr) {
        return GetMaxLength(arr, 0, "");
    }

    int GetMaxLength(IList<string> arr, int i, string concat) {
        if(i >= arr.Count) {
            return concat.Length;
        }
        var joined = arr[i] + concat;
        var include = IsConcatUnique(joined) ? GetMaxLength(arr, i + 1, joined) : 0;
        var exclude = GetMaxLength(arr, i + 1, concat);
        return Math.Max(include, exclude);
    }

    bool IsConcatUnique(string concat){
        var set = new HashSet<char>(concat);
        return set.Count == concat.Length;
    }
}