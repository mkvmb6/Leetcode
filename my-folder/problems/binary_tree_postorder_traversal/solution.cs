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
    public IList<int> PostorderTraversal(TreeNode root) {
        if(root == null) {
            return new List<int>();
        }
        var stack = new Stack<TreeNode>();
        var result = new List<int>();

        stack.Push(root);

        while(stack.Any()) {
            var peek = stack.Peek();
            var hasChild = false;
            if(peek.right != null) {
                stack.Push(peek.right);
                peek.right = null;
                hasChild = true;
            }
            if(peek.left != null) {
                stack.Push(peek.left);
                peek.left = null;
                hasChild = true;
            }
            
            if(!hasChild){
                stack.Pop();
                result.Add(peek.val);
            }
        }
        return result;
    }
}