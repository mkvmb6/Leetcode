public class Solution {
    public int MaxDistance(int[] position, int m) {
        Array.Sort(position);
        int left = 1;
        int right = 1000000000;
        int result = -1;
        while(left <= right) {
            var mid = left + (right - left) / 2;
            if(IsPossible(position, m, mid)) {
                result = mid;
                left = mid + 1;
            }
            else {
                right = mid - 1;
            }
        }
        return result;
    }

    bool IsPossible(int[] position, int m, int force) {
        int last = 0;
        int i = 1;
        var len = position.Length;
        while(m > 1 && i < len) {
            if(position[i] -  position[last] >= force){
                m--;
                last=i;
            }
            i++;
        }
        return m == 1;
    }
}