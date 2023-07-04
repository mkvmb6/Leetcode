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
    public bool IsValidBST(TreeNode root) {
        return ValidateBst(root, long.MinValue+1, long.MaxValue-1);
    }
    
	bool ValidateBst(TreeNode tree, long min, long max) 
    {
        if(tree==null){
            return true;
        }
        long treeVal = tree.val;
        if(treeVal < min || treeVal > max){
            return false;
        }
        return ValidateBst(tree.left, min, treeVal-1) && 
            ValidateBst(tree.right, treeVal+1, max);
	}
}