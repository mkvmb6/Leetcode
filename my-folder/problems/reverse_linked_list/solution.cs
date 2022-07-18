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
    public ListNode ReverseList(ListNode head) {
        if(head==null){
            return null;
        }
        ListNode p = null;
        var c = head;
        var n = head.next;
        while(n!=null){
            c.next=p;
            p=c;
            c=n;
            n=n.next;
        }
        c.next=p;
        return c;
    }
}