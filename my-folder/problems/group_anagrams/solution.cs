public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var groupMap = new Dictionary<string, IList<string>>();
        foreach(var str in strs){
            var countKey = GetCountKey(str);
            if(!groupMap.ContainsKey(countKey)){
                groupMap[countKey]=new List<string>();
            }
            groupMap[countKey].Add(str);
        }
        return groupMap.Values.ToList();
    }
    
    string GetCountKey(string str){
        var arr = new int[26];
        foreach(char ch in str){
            arr[ch-'a']+=1;
        }
        return string.Join(',', arr);
    }
}