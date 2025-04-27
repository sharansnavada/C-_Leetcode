/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        bool hasCycle = false;
        int pos = 0;
        ListNode current = head;
        Dictionary<ListNode,int> dict = new Dictionary<ListNode,int>();
        int index = 0;

        while(current != null){
            if(!dict.ContainsKey(current)){
                dict[current] = index;
                index++;
                current = current.next;
            }
            else{
                pos = dict[current];
                hasCycle = true;
                break;
            }
        }
        return hasCycle;
    }
}
