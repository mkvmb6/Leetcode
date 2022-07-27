class Solution {
public:
    long long subArrayRanges(vector<int>& nums) {
        long long ans = 0;
        int s = nums.size();
        for (int i = 0; i < s; i++) {
            int minV = nums[i];
            int maxV = nums[i];
            for (int j = i + 1; j < s; j++) {
                minV = min(minV, nums[j]);
                maxV = max(maxV, nums[j]);
                ans += (maxV - minV);
            }
        }
        
        return ans;
    }
};