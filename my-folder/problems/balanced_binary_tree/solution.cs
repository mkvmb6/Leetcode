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
    public bool IsBalanced(TreeNode root) {
        return IsBalancedTree(root).isBalanced;
    }

    (bool isBalanced, int height) IsBalancedTree(TreeNode node){
        if(node==null){
            return (true, 0);
        }
        var left = IsBalancedTree(node.left);
        var right = IsBalancedTree(node.right);
        if(left.isBalanced && right.isBalanced){
            var isBalanced = Math.Abs(left.height-right.height) < 2;
            return (isBalanced, 1+Math.Max(left.height, right.height));
        }
        return (false, -1);
    }
}