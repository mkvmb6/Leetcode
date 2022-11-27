public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var groupMap = new Dictionary<string, IList<string>>();
        foreach(var str in strs){
            var countKey = GetCountKey(str);
            if(groupMap.ContainsKey(countKey)){
                groupMap[countKey].Add(str);
            }
            else{
                groupMap[countKey]=new List<string>{str};
            }
        }
        return groupMap.Values.ToList();
    }
    
    string GetCountKey(string str){
        var arr = new int[26];
        foreach(char c in str){
            arr[c-'a']+=1;
        }
        return string.Join(',', arr);
    }
}