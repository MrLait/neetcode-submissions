public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        if(nums.Length == 0) return 0;
        
        var set = new HashSet<int>(nums);
        int maxLen = 0, len = 0;
        var value = 0;
        for(int i = 0; i < nums.Length; i ++)
        {
            value = nums[i];

            if(set.Contains(value - 1))
                continue;
            else
            {
                while(set.Contains(value + 1))
                {
                    len++;
                    value++;
                }

                maxLen = Math.Max(len, maxLen);
            }

            len = 0;
        }

        return maxLen + 1;
    }
}
