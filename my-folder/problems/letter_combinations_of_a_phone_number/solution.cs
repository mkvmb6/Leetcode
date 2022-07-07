public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if(string.IsNullOrEmpty(digits)){
            return new List<string>();
        }
        var digitMap=new Dictionary<char, string[]>{
            {'2',new []{"a", "b", "c"}},
            {'3',new []{"d", "e", "f"}},
            {'4',new []{"g", "h", "i"}},
            {'5',new []{"j", "k", "l"}},
            {'6',new []{"m", "n", "o"}},
            {'7',new []{"p", "q", "r", "s"}},
            {'8',new []{"t", "u", "v"}},
            {'9',new []{"w", "x", "y", "z"}}
        };
               
        var result = GetCombinations(digits, digitMap, 0);
        return result;
    }
    
    IList<string> GetCombinations(string digits, Dictionary<char, string[]> digitMap, int index){
        if(index==digits.Length-1){
            return digitMap[digits[index]];
        }
        var current = digitMap[digits[index]];
        var combs = GetCombinations(digits, digitMap, index+1);
        var result = new List<string>();
        foreach(var curr in current){
            foreach(var comb in combs){
                result.Add(curr+comb);
            }
        }
        return result;
    }
}