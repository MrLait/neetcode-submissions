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
        var result = BinarySearch(nums[..pivot], target);
        
        if(result != -1)
            return result;

        result = BinarySearch(nums[pivot..], target);

        return result == -1 ? -1 : result + pivot;
    }

    private int BinarySearch(int[] nums, int target)
    {
        int m = 0, l = 0, r = nums.Length - 1;

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
