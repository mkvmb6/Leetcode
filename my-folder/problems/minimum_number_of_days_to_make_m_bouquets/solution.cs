public class Solution {
    public int MinDays(int[] bloomDay, int m, int k) {
        int left = 1;
        int right = 1000000000;
        var result = -1;
        while(left <= right) {
            var mid = left + (right - left) / 2;
            if(IsPossible(bloomDay, m, k, mid)) {
                result = mid;
                right = mid - 1;
            }
            else {
                left = mid + 1;
            }
        }
        return result;
    }

    bool IsPossible(int[] bloomDay, int m, int k, int day) {
        int i = 0;
        var len = bloomDay.Length;
        while(m > 0 && i < len) {
            var count = 0;
            while(count < k && i < len) {
                if(bloomDay[i] - day <= 0) {
                    count++;
                    i++;
                }
                else{
                    break;
                }
            }
            if(count == k) {
                m--;
                i--;
            }
            i++;
        }
        return m == 0;
    }
}