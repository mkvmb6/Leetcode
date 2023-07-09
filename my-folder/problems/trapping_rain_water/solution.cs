public class Solution {
    public int Trap(int[] heights) {
        var len = heights.Length;
		var left = 0;
        var right = len - 1;
        var leftMax = 0;
        var rightMax = 0;
        var water = 0;
        while(left < right){
            leftMax = Math.Max(leftMax, heights[left]);
            rightMax = Math.Max(rightMax, heights[right]);
            if(leftMax > rightMax){
                water += Math.Max(0, rightMax - heights[right]);
                right--;
            }
            else{
                water += Math.Max(0, leftMax - heights[left]);
                left++;                
            }
        }
		return water;        
    }
}