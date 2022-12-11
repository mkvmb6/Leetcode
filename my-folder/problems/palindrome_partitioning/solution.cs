public class Solution {
    public IList<IList<string>> Partition(string s) {
        var result = new List<IList<string>>();
        FindPartitions(0, s, new List<string>(), result);
        return result;
    }

    private void FindPartitions(int index, string s, IList<string> partitions, IList<IList<string>> result){
        if(index==s.Length){
            result.Add(partitions.ToList());
            return;
        }
        for(int i=index;i<s.Length;i++){
            if(IsPalindrome(s, index, i)){
                partitions.Add(s.Substring(index, i-index+1));
                FindPartitions(i+1, s, partitions, result);
                partitions.RemoveAt(partitions.Count-1);
            }
        }
    }

    bool IsPalindrome(string s, int start, int end){
        while(start<end){
            if(s[start]!=s[end]){
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}