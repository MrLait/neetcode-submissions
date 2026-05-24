public class Solution {
    public int FindMin(int[] nums)
    {
        int l = 0, r = nums.Length - 1, m = 0;

        while(l <= r)
        {
            if(nums[l] < nums[r])
                return nums[l];
            m = l + (r - l) / 2;

            if(nums[m] >= nums[l])
            {
                if(nums[l] > nums[r])
                    l = m + 1;
                else
                    return nums[l];
            }
            else
            {
                r = m;
            }
        }

        return nums[m];
    }
}
