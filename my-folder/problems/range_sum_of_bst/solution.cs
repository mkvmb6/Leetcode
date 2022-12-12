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
    public int RangeSumBST(TreeNode root, int start, int end) {
        if(root==null){
            return 0;
        }
        if(start < root.val && end < root.val){
            return RangeSumBST(root.left, start, end);
        }
        if(start > root.val && end > root.val){
            return RangeSumBST(root.right, start, end);
        }
        return root.val + RangeSumBST(root.left, start, end) + RangeSumBST(root.right, start, end);
    }
}
