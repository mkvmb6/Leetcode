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
    public TreeNode SortedArrayToBST(int[] nums) {
        return InsertNodes(nums, 0, nums.Length - 1);
    }

    TreeNode InsertNodes(int[] nums, int start, int end){
        if(start > end){
            return null;
        }
        if(start==end){
            return new TreeNode(nums[start]);
        }
        var mid = (start+end)/2;
        var node = new TreeNode(nums[mid]);
        node.left = InsertNodes(nums, start, mid - 1);
        node.right = InsertNodes(nums, mid+1, end);
        return node;
    }
}

/*

 1  2   3   4   5   6   7   8   9   10  11  12  13  14  15  

                                8
                        4               12
                    2       6       10      14
                1       3 5   7    9   11  13  15


                1      2    3   4

                2
            1       3 

*/