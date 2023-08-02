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
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        var result = new List<IList<int>>();
        ExploreSum(root, targetSum, 0, new List<int>(), result);
        return result;
    }

    void ExploreSum(TreeNode node, int targetSum, int prev, List<int> temp, IList<IList<int>> result) {
        if(node == null) {
            return;
        }
        if(node.left == null && node.right == null) {
            if(prev + node.val == targetSum) {
                temp.Add(node.val);
                result.Add(temp.ToList());
                temp.RemoveAt(temp.Count - 1);
            }
            return;
        }

        var sum = prev + node.val;
        temp.Add(node.val);
        ExploreSum(node.left, targetSum, sum, temp, result);
        ExploreSum(node.right, targetSum, sum, temp, result);
        temp.RemoveAt(temp.Count - 1);
    }
}