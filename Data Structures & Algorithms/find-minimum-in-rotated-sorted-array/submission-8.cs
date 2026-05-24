public class Solution {
    public int FindMin(int[] nums)
    {
        int l = 0, r = nums.Length - 1, m = 0;
        var result = nums[l];
        
        while(l <= r)
        {
            if(nums[l] < nums[r])
                return Math.Min(result, nums[l]);

            m = l + (r - l) / 2;
            result = Math.Min(result, nums[m]);

            if(nums[m] >= nums[l])
                l = m + 1;
            else
                r = m - 1;
        }

        return result;
    }
}
