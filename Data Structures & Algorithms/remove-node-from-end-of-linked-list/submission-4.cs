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
        var count = 0;    
        var nodeLength = 0;
        var cur = head;
        
        while(cur is not null)
        {
            nodeLength++;
            cur = cur.next;
        }

        if(nodeLength == n)
        {
            head = head.next;
            return head;
        }

        cur = head;
        ListNode prev = null;

        while(cur is not null)
        {
            if(count == nodeLength - n)
            {
                prev.next = cur.next ?? null;
                break;
            }

            count++;
            prev = cur;
            cur = cur.next;
        }
        return head;
    }
}
