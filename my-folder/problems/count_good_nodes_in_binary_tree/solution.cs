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
    public int GoodNodes(TreeNode root) {
        return findGoodNodes(root, int.MinValue);
    }
    
    int findGoodNodes(TreeNode root, int maxValue){
        if(root==null){
            return 0;
        }
        int count = root.val >= maxValue ? 1 : 0;
        maxValue = Math.Max(maxValue, root.val);
        count += findGoodNodes(root.left, maxValue);
        count += findGoodNodes(root.right, maxValue);
        return count;
    }
}