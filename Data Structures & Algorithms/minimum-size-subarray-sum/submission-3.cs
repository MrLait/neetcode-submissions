public class Solution {
    public int MinSubArrayLen(int target, int[] nums)
    {
        int slow = 0, prefixSum = 0;
        var minSubArrLen = int.MaxValue;

        for(var fast = 0; fast < nums.Length; fast++)
        {
            prefixSum += nums[fast];

            while(prefixSum >= target)
            {
                minSubArrLen = Math.Min(minSubArrLen, fast - slow);
                prefixSum -= nums[slow++];
            }
        }

        return minSubArrLen == int.MaxValue ? 0 : minSubArrLen + 1;
    }
}