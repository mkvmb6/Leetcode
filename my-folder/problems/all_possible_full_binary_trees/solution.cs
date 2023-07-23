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
    public IList<TreeNode> AllPossibleFBT(int n) {
        if(n%2==0){
            return new List<TreeNode>();
        }
        var cache = new Dictionary<int, List<TreeNode>>();
        return GetNodes(n, cache);
    }

    List<TreeNode> GetNodes(int n, Dictionary<int, List<TreeNode>> cache){
        if(n == 1){
            return new List<TreeNode>{new TreeNode(0)};
        }
        if(cache.ContainsKey(n)){
            return cache[n];
        }
        var result = new List<TreeNode>();
        for(int i=1;i<n;i+=2){
            var leftNodes = GetNodes(i, cache);
            var rightNodes = GetNodes(n - i - 1, cache);
            foreach(var left in leftNodes){
                foreach(var right in rightNodes){
                    result.Add(new TreeNode(0, left, right));
                }
            }
        }
        return cache[n] = result;
    }
}























