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
    public List<List<Integer>> findLeaves(TreeNode root) {
        List<List<Integer>> result = new ArrayList<>();
        getHeight(root, result);
        return result;
    }

    int getHeight(TreeNode node, List<List<Integer>> result){
        if(node == null){
            return -1;
        }

        int leftHeight = 1 + getHeight(node.left, result);
        int rightHeight = 1 + getHeight(node.right, result);
        int maxHeight = Math.max(leftHeight, rightHeight);
        if(maxHeight==result.size()){
            result.add(new ArrayList<Integer>());
        }
        result.get(maxHeight).add(node.val);
        return maxHeight;

    }
}