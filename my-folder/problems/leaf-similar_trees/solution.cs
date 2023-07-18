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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var leaves1 = new List<TreeNode>();
        GetLeaves(root1, leaves1);
        var leaves2 = new List<TreeNode>();
        GetLeaves(root2, leaves2);
        if(leaves1.Count != leaves2.Count){
            return false;
        }

        for(int i=0;i<leaves1.Count;i++){
            if(leaves1[i].val != leaves2[i].val){
                return false;
            }
        }
        return true;
    }

    void GetLeaves(TreeNode node, List<TreeNode> list){
        if(node == null){
            return;
        }
        if(node.left == null && node.right == null){
            list.Add(node);
            return;
        }
        GetLeaves(node.left, list);
        GetLeaves(node.right, list);
    }
}