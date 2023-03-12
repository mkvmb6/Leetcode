public class Solution {
    public int RomanToInt(string s) {
        var map = new Dictionary<char, int>{
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
        var len = s.Length;
        int sum = 0;
        int i = 0;
        while(i < len){
            if(i < len - 1 && map[s[i]] < map[s[i+1]]){
                sum+=map[s[i+1]]-map[s[i]];
                i=i+1;
            }
            else{
                sum+=map[s[i]];
            }
            i++;
        }
        return sum;
    }
}