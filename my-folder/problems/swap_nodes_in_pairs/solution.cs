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
    public ListNode SwapPairs(ListNode head) {
        if(head==null || head.next==null){
            return head;
        }
        var next = head.next.next;
        head.next.next=head;
        var tmp = head.next;
        head.next = SwapPairs(next);
        return tmp;
    }
}