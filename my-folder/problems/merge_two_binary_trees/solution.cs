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
    public TreeNode MergeTrees(TreeNode tree1, TreeNode tree2) {
        if(tree1==null && tree2==null){
            return null;
        }
        var val = (tree1==null?0:tree1.val)+(tree2==null?0:tree2.val);
		return new TreeNode(val, MergeTrees(tree1?.left, tree2?.left), MergeTrees(tree1?.right, tree2?.right));
    }
}