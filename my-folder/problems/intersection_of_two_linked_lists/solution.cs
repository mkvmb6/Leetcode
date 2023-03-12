/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {        
        var head1 = headA;
        var head2 = headB;
        while(head1!=head2){
            head1=head1==null?headB:head1.next;
            head2=head2==null?headA:head2.next;
        }
        return head1;
    }
}