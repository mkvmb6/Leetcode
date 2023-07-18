public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        var len = flowerbed.Length;
        int i = 0;
        int count = 0;
        while(i < len && count < n){
            if(flowerbed[i] == 0){
                var leftEmpty = i == 0 || flowerbed[i-1]==0;
                var rightEmpty = i == len - 1 || flowerbed[i+1]==0;
                if(leftEmpty && rightEmpty){
                    flowerbed[i] = 1;
                    count++;
                }
            }
            i++;
        }
        return count == n;
    }
}