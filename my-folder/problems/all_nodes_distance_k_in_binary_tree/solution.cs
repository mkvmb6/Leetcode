/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> DistanceK(TreeNode root, TreeNode target, int k) {
        var parents = new Dictionary<TreeNode, TreeNode>();
        PopulateParents(root, parents);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(target);
        var visited = new HashSet<TreeNode>();
        var level = 0;
        while(queue.Any()){
            if(level == k){
                break;
            }
            var n = queue.Count;
            while(n > 0){
                var node = queue.Dequeue();
                visited.Add(node);
                if(node.left!=null && !visited.Contains(node.left)){
                    queue.Enqueue(node.left);
                }
                if(node.right!=null && !visited.Contains(node.right)){
                    queue.Enqueue(node.right);
                }
                if(parents.ContainsKey(node) && !visited.Contains(parents[node])){
                    queue.Enqueue(parents[node]);
                }
                n--;
            }
            level++;
        }
        return queue.Select(node=>node.val).ToList();
    }

    void PopulateParents(TreeNode node, Dictionary<TreeNode, TreeNode> parents){
        if(node == null){
            return;
        }
        if(node.left!=null){
            parents[node.left] = node;
        }
        PopulateParents(node.left, parents);
        if(node.right!=null){
            parents[node.right] = node;
        }
        PopulateParents(node.right, parents);
    }
}