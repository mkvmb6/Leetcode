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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var s1 = new Stack<ListNode>();
        while(l1!=null){
            s1.Push(l1);
            l1=l1.next;
        }
        var s2 = new Stack<ListNode>();
        while(l2!=null){
            s2.Push(l2);
            l2=l2.next;
        }
        var sum = 0;
        var carry = 0;
        var result = new Stack<ListNode>();
        while(s1.Any() || s2.Any()){
            sum = carry;
            if(s1.Any()){
                sum += s1.Pop().val;
            }
            if(s2.Any()){
                sum += s2.Pop().val;
            }
            result.Push(new ListNode(sum%10));
            carry = sum / 10;
        }
        if(carry != 0){
            result.Push(new ListNode(carry));
        }

        var head = result.Pop();
        var current = head;
        while(result.Any()){
            var node = result.Pop();
            current.next = node;
            current = node;
        }
        
        return head;
    }
}