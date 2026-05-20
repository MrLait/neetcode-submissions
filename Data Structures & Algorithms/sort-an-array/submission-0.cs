public class Solution {
    public int[] SortArray(int[] nums)
    {
        var pq = new PriorityQueue<int, int>();

        foreach(var n in nums)
        {
            pq.Enqueue(n, n);
        }    

        for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = pq.Dequeue();
        }

        return nums;
    }
}