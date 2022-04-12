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
    static int minCol=0;
    static int maxCol=0;
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        if(root == null){
            return new List<IList<int>>{new List<int>()};
        }
        minCol = 0;
        maxCol = 0;
        var nodes = new Dictionary<int, List<MyNode>>();
        PopulateNodes(root, nodes, 0, 0);
        var result = new List<IList<int>>();
        int startCol = minCol;
        while(startCol<=maxCol){
            result.Add(nodes[startCol].OrderBy(n=>n.Row)
                       .GroupBy(n=>n.Row)
                       .SelectMany(g=>g.Select(n=>n.Node.val).OrderBy(v=>v)).ToList());
            startCol++;
        }
        return result;
    }
    
    private void PopulateNodes(TreeNode root, Dictionary<int, List<MyNode>> nodes, int row, int col)
    {
        if(root == null){
            return;
        }
        if(nodes.ContainsKey(col)){
            nodes[col].Add(new MyNode{Node = root, Row=row});
        }
        else{
            nodes[col]= new List<MyNode>{new MyNode{Node = root, Row=row}};
        }
        minCol = Math.Min(minCol, col);
        maxCol = Math.Max(maxCol, col);
        PopulateNodes(root.left, nodes, row+1, col-1);
        PopulateNodes(root.right, nodes, row+1, col+1);
    }
}

public class MyNode
{
    public TreeNode Node{get;set;}
    public int Row{get;set;}
    
}