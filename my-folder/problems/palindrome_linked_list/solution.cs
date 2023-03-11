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
    ListNode front;
    public bool IsPalindrome(ListNode head) {
        front = head;
        return IsEqual(head);
    }

    bool IsEqual(ListNode root){
        if(root==null){
            return true;
        }
        if(!IsEqual(root.next)){
            return false;
        }
        if(root.val != front.val){
            return false;
        }
        front = front.next;
        return true;
    }
}