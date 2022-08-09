class Solution:
    def runningSum(self, nums: List[int]) -> List[int]:
        result = []
        x = 0
        for i in range(len(nums)):
            x+=nums[i]
            result.append(x)
        return result