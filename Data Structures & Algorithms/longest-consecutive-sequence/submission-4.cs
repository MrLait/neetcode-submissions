public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        if(nums.Length == 0) return 0;

        var pq = new PriorityQueue<int,int>();
        int maxSecuenceLen = 1, secuenceLen = 1;

        foreach(var num in nums)
            pq.Enqueue(num,num);
        
        int prev = pq.Dequeue(), cur = 0;
        for(var i = 1; i < nums.Length; i++)
        {
            cur = pq.Dequeue();
            if(prev == cur) continue;

            if(prev + 1 == cur)
            {
                secuenceLen++;
            }
            else if(prev + 1 != cur)
            {
                secuenceLen = 1;
            }
            
            maxSecuenceLen = Math.Max(maxSecuenceLen, secuenceLen);
            prev = cur;
        }
        
        return maxSecuenceLen;
    }
}
