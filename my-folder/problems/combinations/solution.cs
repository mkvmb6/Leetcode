public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        var result = new List<IList<int>>();
        GetCombinations(1, n, k, new List<int>(), result);
        return result;
    }

    void GetCombinations(int i, int n, int k, IList<int> temp, IList<IList<int>> result) {
        if(k == 0) {
            result.Add(temp.ToList());
            return;
        }

        if(i > n) {
            return;
        }

        temp.Add(i);
        GetCombinations(i + 1, n, k - 1, temp, result);
        temp.RemoveAt(temp.Count - 1);
        GetCombinations(i + 1, n, k, temp, result);
    }
}