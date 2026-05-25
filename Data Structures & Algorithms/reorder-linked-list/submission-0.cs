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
    public void ReorderList(ListNode head)
    {
        var slow = head;
        var fast = head;

        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

        }

        ListNode reversed = slow.next;
        slow.next = null;
        var prev = slow.next;

        while(reversed != null)
        {
            var next = reversed.next; 
            reversed.next = prev; 
            prev = reversed; 
            reversed = next; 
        }

        reversed = prev;
        var first = head;

        while(reversed != null)
        {
            var tmp1 = first.next; // 4,6
            var tmp2 = reversed.next; // 10
            first.next = reversed; // 2, 8, 10
            reversed.next = tmp1; // 8, 4, 6
            first = tmp1; // 4,6
            reversed = tmp2; // 10
        }
    }
}
