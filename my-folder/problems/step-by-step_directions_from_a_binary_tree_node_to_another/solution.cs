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
    StringBuilder res = new StringBuilder();
    public string GetDirections(TreeNode root, int startValue, int destValue) {
        var lca = FindLCA(root, startValue, destValue);
         MakeAmanPath(lca, startValue, true);
        var leftPath = res.ToString();
        res.Clear();
        MakeAmanPath(lca, destValue, false);
        return leftPath+new string(res.ToString().Reverse().ToArray());
    }
    
    TreeNode FindLCA(TreeNode root, int left, int right){
        if(root==null || root.val==left || root.val==right){
            return root;
        }
        
        var leftNode = FindLCA(root.left, left, right);
        var rightNode = FindLCA(root.right, left, right);
        
        if(leftNode!=null && rightNode!=null){
            return root;
        }
        return leftNode!=null?leftNode:rightNode;
    }
    
    string MakePath(TreeNode root, int target, StringBuilder prevPath, bool traceUp){
        if(root==null){
            return null;
        }
        if(target==root.val){
            return prevPath.ToString();
        }
        var leftPath = MakePath(root.left, target, traceUp?prevPath.Insert(0, "U"):prevPath.Append("L"), traceUp);
        if(leftPath==null){
          if(traceUp)  prevPath.Remove(0, 1);
            else prevPath.Length--;
        }
        var rightPath = MakePath(root.right, target,  traceUp?prevPath.Insert(0, "U"):prevPath.Append("R"), traceUp);
        if(rightPath==null){
          if(traceUp)  prevPath.Remove(0, 1);
            else prevPath.Length--;
        }
        return leftPath!=null?leftPath:rightPath;
    }
    
    bool MakeAmanPath(TreeNode root, int target, bool traceUp){
        if(root==null){
            return false;
        }
        if(target==root.val){
            return true;
        }
        var isLeftFound = MakeAmanPath(root.left, target, traceUp);
        var isRightFound = false;
        if(isLeftFound){
            res.Append(traceUp?"U":"L");
        }
        else {
            isRightFound = MakeAmanPath(root.right, target, traceUp);
            if(isRightFound)
                res.Append(traceUp?"U":"R");
        }
        return isLeftFound || isRightFound;
    }
    
}
