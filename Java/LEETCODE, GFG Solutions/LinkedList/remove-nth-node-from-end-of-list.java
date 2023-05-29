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
    public ListNode removeNthFromEnd(ListNode head, int n) {
        if(head.next == null) return null;
        ListNode temp = null;
        ListNode slow = head;
        ListNode fast = head;
        for(int i = 1; fast.next != null && i < n; i++) fast = fast.next;
        while(fast.next != null){
            temp = slow;
            slow = slow.next;
            fast = fast.next;
        }
        if(temp == null) {
            head = head.next;
            return head;
        }
        temp.next = slow.next;
        return head;
    }
}