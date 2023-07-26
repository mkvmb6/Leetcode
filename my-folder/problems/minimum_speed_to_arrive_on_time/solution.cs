public class Solution {
    public int MinSpeedOnTime(int[] dist, double hour) {
        var left = 1;
        var right = 10000000;
        var minSpeed = -1;

        while(left <= right) {
            var speed = left + (right - left) / 2;
            if(IsPossibleToReach(dist, speed, hour)){
                minSpeed = speed;
                right = speed - 1;
            }
            else {
                left = speed + 1;
            }
        }
        return minSpeed;
    }

    bool IsPossibleToReach(int[] dist, int speed, double hour) {
        var totalTime = 0.0;
        int i = 0;
        while (i < dist.Length - 1){
            totalTime += Math.Ceiling(dist[i++] * 1.0 / speed);
        }
        totalTime += dist[i] * 1.0 / speed;
        return totalTime <= hour;
    }
}