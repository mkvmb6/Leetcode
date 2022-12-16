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
    public ListNode MergeKLists(ListNode[] lists) {
        var pq = new PriorityQueue<ListNode, int>();
        foreach(var node in lists){
            if(node!=null){
                pq.Enqueue(node, node.val);
            }            
        }
        var result = new ListNode();
        var head = result;
        while(pq.Count>0){
            var node = pq.Dequeue();
            result.next = node;
            result = result.next;
            node = node.next;
            if(node!=null){
                pq.Enqueue(node, node.val);
            }
        }
        return head.next;
    }
}