public class Solution {
    public int HammingDistance(int x, int y) {
        int r = x ^ y;
        int count = 0;
        while(r!=0){
            if((r&1)==1){
                count++;
                r=r & (~1);
            }
            r = r >> 1;
        }
        return count;
    }
}