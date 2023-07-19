public class Solution {
    public string RemoveStars(string s) {
        var stack = new Stack<char>();
        foreach(var ch in s){
            if(ch!='*'){
                stack.Push(ch);
            }
            else{
                stack.Pop();
            }
        }
        var result = new StringBuilder();
        while(stack.Any()){
            result.Append(stack.Pop());
        }
        return new String(result.ToString().Reverse().ToArray());
    }
}