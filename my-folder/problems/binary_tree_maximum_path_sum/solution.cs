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
    int maxSum = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        FindMaxPathSum(root);
        return maxSum;
    }
    
    int FindMaxPathSum(TreeNode root){
        if(root==null){
            return 0;
        }
        int leftSum = FindMaxPathSum(root.left);
        int rightSum = FindMaxPathSum(root.right);
        int maxSubTreeSum =Math.Max(root.val, Math.Max(root.val + leftSum, root.val + rightSum));
        int maxSumHere = Math.Max(maxSubTreeSum, root.val + leftSum + rightSum);
        maxSum = Math.Max(maxSum, maxSumHere);
        return maxSubTreeSum;
    }
}