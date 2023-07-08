/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode InorderSuccessor(TreeNode node, TreeNode p) {        
		TreeNode result = null;
        while(node!=null){
            if(node.val <= p.val){
                node=node.right;
                continue;
            }
            result = node;
            node = node.left;
        }
        return result;
    }
}