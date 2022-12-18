public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int>();
        var len = temperatures.Length;
        var result = new int[len];
        for(int i=len-1;i>=0;i--){
            while(stack.Count > 0 && temperatures[stack.Peek()] <= temperatures[i]){
               stack.Pop();
            }
            result[i]=stack.Count> 0?stack.Peek()-i:0;
            stack.Push(i);
        }
        return result;
    }
}