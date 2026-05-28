public class Solution
{
    public List<int> MajorityElement(int[] nums)
    {
        if (nums.Length == 1)
            return new List<int> { nums[0] };

        var result = new List<int>();
        int needed = nums.Length / 3;
        Array.Sort(nums);

        int candidate1 = nums[nums.Length / 3];
        int candidate2 = nums[2 * nums.Length / 3];

        if (IsMajorityElement(candidate1, nums, needed))
            result.Add(candidate1);

        if (candidate1 != candidate2 && IsMajorityElement(candidate2, nums, needed))
            result.Add(candidate2);

        return result;
    }

    private bool IsMajorityElement(int candidate, int[] nums, int needed)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == candidate)
            {
                count++;
                if (count > needed)
                    return true;
            }
        }
        return false;
    }
}