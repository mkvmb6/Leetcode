public class Solution {
    public bool IsCovered(int[][] ranges, int left, int right) {
        var items = new int[52];
        foreach(var item in ranges){
            items[item[0]]++;
            items[item[1]+1]--;
        }
        var sum  = 0;
        for(int i=0;i<51;i++){
            sum+=items[i];
            if(i>=left && i<=right){
                if(sum < 1){
                    return false;
                }
            }
        }
        return true;
    }
}