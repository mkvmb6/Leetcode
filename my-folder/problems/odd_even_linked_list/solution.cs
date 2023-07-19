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
    public ListNode OddEvenList(ListNode head) {
        if(head==null){
            return null;
        }
        var odd = head;
        var even = head.next;
        ListNode evenHead = even;
        ListNode oddTail = null;
        while(even!=null){
            odd.next = odd.next?.next;
            oddTail = odd;
            odd = odd.next;
            even.next = even.next?.next;
            even = even.next;
        }
        (odd ?? oddTail).next = evenHead;
        return head;
    }
}