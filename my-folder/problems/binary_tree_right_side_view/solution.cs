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
    public IList<int> RightSideView(TreeNode root) {
        var result = new List<int>();
        if(root==null){
            return result;
        }
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Any()){
            var len = queue.Count;
            int i = 1;
            while(i < len){
                var item = queue.Dequeue();
                if(item.left!=null){
                    queue.Enqueue(item.left);
                }
                if(item.right!=null){
                    queue.Enqueue(item.right);
                }
                i++;
            }
            var lastItem = queue.Dequeue();
            result.Add(lastItem.val);
            if(lastItem.left!=null){
                queue.Enqueue(lastItem.left);
            }
            if(lastItem.right!=null){
                queue.Enqueue(lastItem.right);
            }

        }
        return result;
    }
}