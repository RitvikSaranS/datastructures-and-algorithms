/**
 * Definition for singly-linked list.
 * class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode detectCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        int cycleLength = 0;
        // Cycle Detection
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
            // If fast meets slow that means there is cycle
            if(fast == slow) {
                cycleLength = findLength(slow);
                break;
            }
        }
        // cycleLength = 0 means findLength is not called.
        if(cycleLength == 0) return null;
        //Steps from here is explained below.
        slow = head;
        fast = head;
        while(cycleLength > 0){
            fast = fast.next;
            cycleLength--;
        }
        while(slow != fast){
            slow = slow.next;
            fast = fast.next;
        }
        return slow;
    }
    public int findLength(ListNode head){
        int cycleLength = 0;
        ListNode slow = head;
        ListNode fast = head;
        do{
            fast = fast.next;
            cycleLength++;
        }while(fast != slow);
        return cycleLength;
    }
}
/*
* The length of the whole linked list would be l + r, where l is the length till the beginning of the cycle and r is the length of the cycle.
* If fast travel r from the beginning, the remaining length for fast is l that lands on the beginning of the cycle. 
* Now start another pointer from the beginning, this pointer has to cover l to reach beginning of the cycle, so if both are moved together they will meet at the beginning of the cycle.
*/