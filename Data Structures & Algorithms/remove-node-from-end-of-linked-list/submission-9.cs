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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var len = 0;
        
        for(var cur = head; cur != null; cur = cur.next)
            len++;

        var dummy = new ListNode(0, head);
        var prev = dummy;

        for(int i = 0; i < len - n; i++)
            prev = prev.next;

        prev.next = prev.next.next;

        return dummy.next;
    }
}
