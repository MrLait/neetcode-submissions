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
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        var cur = head;

        while(cur != null)
        {
            var next = cur.next; //1,2,3 // 2, 3 // 3
            cur.next = prev; // 0, null //  1, 0 // 
            prev = cur; // 0 \\\\       // 1 
            cur = next; // 1,2,3        // 2, 3
        }

        return prev;
    }
}
