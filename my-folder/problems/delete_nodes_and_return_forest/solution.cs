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
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) {
        var deleteSet = to_delete.ToHashSet();
        var rootList = new List<TreeNode>();
        DeleteNodes(root, deleteSet, rootList, true);
        return rootList;
    }

    private TreeNode DeleteNodes(TreeNode node, HashSet<int> deleteSet, List<TreeNode> rootList, bool isParentDeleted){
        if(node==null){
            return null;
        }
        var toBeDeleted = deleteSet.Contains(node.val);
        if(!toBeDeleted && isParentDeleted){
            rootList.Add(node);
        }
        node.left = DeleteNodes(node.left, deleteSet, rootList, toBeDeleted);
        node.right = DeleteNodes(node.right, deleteSet, rootList, toBeDeleted);
        return toBeDeleted? null:node;
    }
}

