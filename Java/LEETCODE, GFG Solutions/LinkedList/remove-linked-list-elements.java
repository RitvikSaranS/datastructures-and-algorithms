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
    public ListNode removeElements(ListNode head, int val) {
        ListNode previous = null;
        ListNode present = head;
        while(present != null){
            if(present.val == val && present == head) {
                head = head.next;
                present = head;
            }
            else if(present.val == val){
                previous.next = present.next;
                present = previous.next;
            }
            else{
            previous = present;
            present = present.next;
            }
        }
        return head;
    }
}