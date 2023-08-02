/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        return ExploreSum(root, targetSum, 0);
    }

    bool ExploreSum(TreeNode node, int targetSum, int prev) {
        if(node == null) {
            return false;
        }
        if(node.left == null && node.right == null) {
            if(prev + node.val == targetSum) {
                return true;
            }
            return false;
        }

        var sum = prev + node.val;
        return ExploreSum(node.left, targetSum, sum) || ExploreSum(node.right, targetSum, sum);
    }
}