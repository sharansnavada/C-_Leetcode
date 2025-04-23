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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        List<int> data = new List<int>();
        ListNode retList = new ListNode(0, null);
        while(list1 != null){
            data.Add(list1.val);
            list1 = list1.next;
        }

        while(list2 != null){
            data.Add(list2.val);
            list2 = list2.next;
        }

        data.Sort();
        int i = 0;
        ListNode retLL = retList;
        while(i < data.Count){
            retLL.next = new ListNode(data[i]);
            retLL = retLL.next;
            i++;
        }

        return retList.next;
    }
}
