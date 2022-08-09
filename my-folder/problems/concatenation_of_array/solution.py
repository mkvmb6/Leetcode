class Solution:
    def getConcatenation(self, nums: List[int]) -> List[int]:
        result = list(nums)
        result.extend(nums)
        return result