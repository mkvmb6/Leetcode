/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public List<TreeNode> delNodes(TreeNode root, int[] to_delete) {
        Set<Integer> delSet = Arrays.stream(to_delete).boxed().collect(Collectors.toSet());
        List<TreeNode> roots = new ArrayList<>();
        PopulateNodes(root, roots, delSet, true);
        return roots;
    }

    TreeNode PopulateNodes(TreeNode node, List<TreeNode> roots, Set<Integer> delSet, boolean isParentDeleted) {
        if(node == null) {
            return null;
        }

        boolean toBeDeleted = delSet.contains(node.val);
        if(!toBeDeleted && isParentDeleted) {
            roots.add(node);
        }

        node.left = PopulateNodes(node.left, roots, delSet, toBeDeleted);
        node.right = PopulateNodes(node.right, roots, delSet, toBeDeleted);

        return toBeDeleted ? null : node;
    }
}