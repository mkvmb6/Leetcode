public class Solution {
    public int LargestAltitude(int[] gain) {
        var max = 0;
        var current = 0;
        foreach(var g in gain){
            current += g;
            max = Math.Max(max, current);
        }
        return max;
    }
}