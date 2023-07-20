public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new Stack<int>();
        var len = asteroids.Length;
        int i = 0;
        while(i<len){
            var val = asteroids[i];
            if(val > 0 || !stack.Any() || stack.Peek() < 0){
                stack.Push(val);
                i++;
                continue;
            }
            var top = stack.Peek();
            var sum = top + val;
            if(sum < 0){
                stack.Pop();
            }
            else if(sum > 0){
                i++;
            }
            else{
                stack.Pop();
                i++;
            }
        }
        var result = stack.ToArray();
        Array.Reverse(result);
        return result;
    }
}