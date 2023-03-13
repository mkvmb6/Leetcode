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
    int maxDia = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        maxDia = 0;
        FindMaxDia(root);
        return maxDia - 1;
    }

    int FindMaxDia(TreeNode root){
        if(root == null){
            return 0;
        }
        var leftDia = FindMaxDia(root.left);
        var rightDia = FindMaxDia(root.right);
        var dia = 1 + leftDia + rightDia;
        maxDia = Math.Max(maxDia, dia);
        return 1 + Math.Max(leftDia , rightDia);
    }
}