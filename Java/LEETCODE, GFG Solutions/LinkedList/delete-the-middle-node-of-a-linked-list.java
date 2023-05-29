/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode deleteMiddle(ListNode head) {
        if(head.next == null) return null;
        ListNode beforeMid = null;
        ListNode mid = head;
        ListNode end = head;
        while(end != null && end.next != null){
            beforeMid = mid;
            mid = mid.next;
            end = end.next.next;
        }
        beforeMid.next = mid.next;
        return head;
    }
}