public class Solution
{
    public int Search(int[] nums, int target)
    {
        int pivot = 0, l = 0, r = nums.Length - 1;
        
        while (l < r)
        {
            int m = l + (r - l) / 2;

            if (nums[m] > nums[r])
                l = m + 1;
            else
                r = m;
        }

        pivot = l;
        
        if(nums[pivot] <= target && target <= nums[nums.Length - 1])
            return BinarySearch(in nums, target, pivot, nums.Length - 1);

        return BinarySearch(in nums, target, 0, pivot - 1);
    }

    private int BinarySearch(in int[] nums, int target, int l, int r)
    {
        int m = 0;

        while(l <= r)
        {
            m = l + (r - l) / 2;

            if(nums[m] == target)
                return m;
            else if(nums[m] < target)
                l = m + 1;
            else
                r = m - 1;

        } 

        return -1;
    }
}
