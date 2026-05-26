/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head)
    {
        var cur = head;
        var map = new Dictionary<Node, Node>();

        while(cur is not null)
        {
            var copy = new Node(cur.val);
            map[cur] = copy;

            cur = cur.next;
        }

        cur = head;

        while(cur is not null)
        {
            var copy = map[cur];
            copy.next = cur.next is not null ? map[cur.next] : null;
            copy.random = cur.random is not null ? map[cur.random] : null;

            cur = cur.next;
        }

        return head is not null ? map[head] : null;

    }
}
