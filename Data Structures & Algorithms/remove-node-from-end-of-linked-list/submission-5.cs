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
        //See solution 2
        ListNode prev = null, cur = head;

        while(cur is not null)
        {
            var next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next;
        }

        var revHead = prev;
        var reversed = revHead;
        ListNode prevNode = null;
        var count = 1;

        while(reversed is not null)
        {
            if(count == n)
            {   
                if(prevNode is not null)
                    prevNode.next = reversed.next;
                else
                    revHead = reversed.next;

                break;
            }

            prevNode = reversed;
            reversed = reversed.next;
            count++;
        }
        
        cur = revHead;
        prev = null;
        while(cur is not null)
        {
            var next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next;
        }

        return prev;
    }
}
