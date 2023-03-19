# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def findLeaves(self, root: Optional[TreeNode]) -> List[List[int]]:
        result = []
        self.getHeight(root, result)
        return result
    def getHeight(self, node, result):
        if not node:
            return -1;
        leftHeight = 1 + self.getHeight(node.left, result)
        rightHeight = 1 + self.getHeight(node.right, result)
        maxHeight = max(leftHeight, rightHeight)
        if len(result)==maxHeight:
            result.append([])
        result[maxHeight].append(node.val)
        return maxHeight