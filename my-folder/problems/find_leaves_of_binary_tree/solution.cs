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
    public IList<IList<int>> FindLeaves(TreeNode root) {
        var rankMap = new Dictionary<int, IList<int>>();
        var result= new List<IList<int>>();
        GetRank(root, result);
        return result;
    }

    int GetRank(TreeNode node, IList<IList<int>> result){
        if(node==null){
            return -1;
        }
        var leftRank = 1 + GetRank(node.left, result);
        var rightRank = 1 + GetRank(node.right, result);
        var rank = Math.Max(leftRank, rightRank);
        if(result.Count==rank){
            result.Add(new List<int>());
        }
        result[rank].Add(node.val);
        return rank;
    }
}