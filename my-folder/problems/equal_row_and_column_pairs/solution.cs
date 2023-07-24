public class Solution {
    public int EqualPairs(int[][] grid) {
        var map = new Dictionary<string, int>();
        foreach(var row in grid){
            var rowString = string.Join(",", row);
            if(!map.ContainsKey(rowString)){
                map[rowString]=0;
            }
            map[rowString]++;
        }
        
        var len = grid.Length;
        var count = 0;
        for(int i=0;i<len;i++){
            var col = new int[len];
            for(int j=0;j<len;j++){
                col[j] = grid[j][i];
            }
            count += map.GetValueOrDefault(string.Join(",", col), 0);
        }
        return count;

    }
}