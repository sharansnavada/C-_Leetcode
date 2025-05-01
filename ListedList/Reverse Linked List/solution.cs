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
    public ListNode ReverseList(ListNode head) {
        ListNode current = head;
        ListNode prev = null;
        ListNode next = new ListNode();

        while(current != null){
            next = current.next;
            current.next = prev;
            prev = current;
            if(next != null){
                current = next;
            }
            else{
                break;
            }
        }
        return current;
    }
}
