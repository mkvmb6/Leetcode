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
    public ListNode ReverseKGroup(ListNode head, int k) {
        var totalNodes = GetTotalNodes(head);
        var totalGroups = totalNodes / k;
        int i = 0;
        ListNode lastNode = head;
        ListNode nextNode = head;
        while(i < totalGroups){
            var nodePair = ReverseKNodes(nextNode, k);
            if(i == 0){
                head = nodePair[0];
            }
            else{
                lastNode.next = nodePair[0];
            }
            lastNode = nodePair[1];
            nextNode = nodePair[2];
            i++;
        }
        lastNode.next = nextNode;
        return head;
    }

    int GetTotalNodes(ListNode head){
        int count = 0;
        while(head!=null){
            head=head.next;
            count++;
        }
        return count;
    }

    private ListNode[] ReverseKNodes(ListNode node, int k){
        int i = 0;
        ListNode prev = null;
        ListNode current = node;
        ListNode next = node;
        while(i < k){
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
            i++;
        }
        return new ListNode[]{prev, node, next};
    }
}