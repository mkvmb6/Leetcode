# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def delNodes(self, root: Optional[TreeNode], to_delete: List[int]) -> List[TreeNode]:
        delSet = set(to_delete)
        roots = []
        self.populateRoots(root, roots, delSet, True)
        return roots

    def populateRoots(self, root, roots, delSet, isParentDeleted):
        if root is None:
            return None
        toBeDeleted = root.val in delSet
        if not toBeDeleted and isParentDeleted:
            roots.append(root)

        root.left = self.populateRoots(root.left, roots, delSet, toBeDeleted)
        root.right = self.populateRoots(root.right, roots, delSet, toBeDeleted)

        return None if toBeDeleted else root
