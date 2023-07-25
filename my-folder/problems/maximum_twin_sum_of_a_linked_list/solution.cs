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
    public int PairSum(ListNode head) {
        var slow = head;
        var fast = head;
        while(fast?.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode next = null;
        ListNode prev = null;

        while(slow != null){
            next = slow.next;
            slow.next = prev;
            prev = slow;
            slow = next;
        }

        var start = head;
        var max = 0;
        while (prev != null) {
            max = Math.Max(max, start.val + prev.val);
            prev = prev.next;
            start = start.next;
        }
        return max;
    }
}