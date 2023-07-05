/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    int GetValue(ref ListNode head){
        int val = -1;
        if(head!=null){
            val = head.val;
            head=head.next;
        }
        return val;
    }
    public int[][] SpiralMatrix(int m, int n, ListNode head) {       
		var spiral = new List<int>();
        var top = 0;
        var left = 0;
        var bottom = m-1;
        var right = n-1;        
        var matrix = new int[m][];
        for(int i=0;i<m;i++){
            matrix[i]=new int[n];
        }
        while(top<=bottom && left<=right){
            for(int i=left;i<=right;i++){                
                matrix[top][i]=GetValue(ref head);
            }
            top++;
            for(int i=top;i<=bottom;i++){
                matrix[i][right]=GetValue(ref head);
            }
            right--;
            if(top<=bottom){
                for(int i=right;i>=left;i--){
                    matrix[bottom][i]=GetValue(ref head);
                }
                bottom--;
            }
            
            if(left<=right){                
                for(int i=bottom;i>=top;i--){
                    matrix[i][left]=GetValue(ref head);
                }
                left++;
            }
        }
        
		return matrix;
        
    }
}