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
    public ListNode ModifiedList(int[] nums, ListNode head) {
        int[] hashTable = new int[100002];
        for(int i = 0; i < nums.Length; i++){
            hashTable[nums[i]]++;
        }

        while(head != null){
            if(hashTable[head.val] != 0){
                head = head.next;
            }
            else{
                break;
            }
        }

        ListNode temp = head;
        ListNode prev = null;

        while(temp != null){
            if(hashTable[temp.val] != 0){
                prev.next = temp.next;
                temp = prev;
            }
            prev = temp;
            temp = temp.next;
        }
        return head;
    }
}
