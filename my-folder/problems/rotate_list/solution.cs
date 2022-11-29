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
    public ListNode RotateRight(ListNode head, int k) {
        if(head==null){
            return null;
        }
        var listLen = 1;
        var current = head;
        while(current.next!=null){
            listLen++;
            current=current.next;
        }
        k=k%listLen;
        if(k==0){
            return head;
        }
        var endNode = current;
        var lastNodeNum = listLen - k;
        int c = 1;
        current = head;
        while(c<lastNodeNum){
            current=current.next;
            c++;
        }
        var startNode = current.next;
        current.next = null;
        endNode.next=head;
        return startNode;
    }
}