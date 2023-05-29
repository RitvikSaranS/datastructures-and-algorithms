https://leetcode.com/problems/reverse-linked-list/
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
    public ListNode reverseList(ListNode head) {
        if(head == null) return head;
        ListNode previous = null; 
        ListNode present = head;
        ListNode after = head.next;
    while (present != null) {
        present.next = previous; //link between present and previous is reversed here
        previous = present;
        present = after;
        if(after != null){
        after = after.next;
        }
    }
        return previous;
}
}

/*
Three pointers => previous, present, after.
In each step we flip the link between present and previous and update all forwards.
Loop terminates when present is null.
*/