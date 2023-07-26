public class Solution {
    public int MinEatingSpeed(int[] piles, int hour) {
        var left = 1;
        var right = 1000000000;
        var minSpeed = -1;

        while(left <= right) {
            var speed = left + (right - left) / 2;
            if(IsPossibleToEat(piles, speed, hour)){
                minSpeed = speed;
                right = speed - 1;
            }
            else {
                left = speed + 1;
            }
        }
        return minSpeed;
    }

    bool IsPossibleToEat(int[] piles, int speed, int hour) {
        var totalTime = 0.0;
        int i = 0;
        while (i < piles.Length - 1){
            totalTime += Math.Ceiling(piles[i++] * 1.0 / speed);
        }
        totalTime += piles[i] * 1.0 / speed;
        return totalTime <= hour;
    }
}