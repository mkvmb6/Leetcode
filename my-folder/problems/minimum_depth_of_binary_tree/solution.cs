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
    public int MinDepth(TreeNode root) {
        if(root == null){
            return 0;
        }
        var left = MinDepth(root.left);
        var right = MinDepth(root.right);
        if(left == 0){
            left = right;
        }
        if(right == 0){
            right = left;
        }
        return 1 + Math.Min(left, right);
    }
}