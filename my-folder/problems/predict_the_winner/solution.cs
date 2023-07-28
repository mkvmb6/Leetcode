public class Solution {
    public bool PredictTheWinner(int[] nums) {
        var sum = nums.Sum();
        var cache = new int[nums.Length + 1, nums.Length + 1];
        var player1Score = GetScore(nums, 0, nums.Length - 1, cache);
        return player1Score >= sum - player1Score;
    }

    int GetScore(int[] nums, int i, int j, int[,] cache) {
        if(i > j) {
            return 0;
        }
        if(cache[i,j] != 0) {
            return cache[i,j];
        }
        var left = nums[i] + Math.Min(GetScore(nums, i+2, j, cache), GetScore(nums, i+1, j-1, cache));
        var right = nums[j] + Math.Min(GetScore(nums, i+1, j-1, cache), GetScore(nums, i, j-2, cache));
        return cache[i,j] = Math.Max(left, right);
    }
}