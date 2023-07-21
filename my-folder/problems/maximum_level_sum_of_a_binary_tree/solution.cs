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
    public int MaxLevelSum(TreeNode root) {
        var maxSum = int.MinValue;
        var maxLevel = 0;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var level = 1;
        while(queue.Any()){
            var len = queue.Count;
            int i = 0;
            var sum = 0;
            while(i < len){
                var item = queue.Dequeue();
                sum+=item.val;
                if(item.left!=null){
                    queue.Enqueue(item.left);
                }
                if(item.right!=null){
                    queue.Enqueue(item.right);
                }
                i++;
            }
            if(sum > maxSum){
                maxSum = sum;
                maxLevel = level;
            }
            level++;
        }
        return maxLevel;
        
    }
}