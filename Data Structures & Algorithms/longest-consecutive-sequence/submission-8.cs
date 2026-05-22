public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        if(nums.Length == 0) return 0;

        var set = new HashSet<int>(nums);
        int maxLen = 0, len = 0;
        var value = 0;

        foreach(var num in nums)
        {
            value = num;
            len = 1;

            if(!set.Contains(value - 1))
            {
                while(set.Contains(value + 1))
                {
                    len++;
                    value++;
                }

                maxLen = Math.Max(len, maxLen);
            }

        }

        return maxLen;
    }
}
