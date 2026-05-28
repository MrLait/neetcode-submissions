public class Solution {
    public List<int> MajorityElement(int[] nums) {
        if (nums.Length == 1)
            return [nums[0]];

        int n = nums.Length, threshold = n / 3;
        var result = new List<int>();

        Array.Sort(nums);
        int candidate1 = nums[threshold], candidate2 = nums[2 * n / 3];

        if (IsTheMajorElement(threshold, nums, threshold))
            result.Add(candidate1);

        if (candidate1 != candidate2 &&
            IsTheMajorElement(n - threshold - 1, nums, threshold))
            result.Add(candidate2);

        return result;
    }

    private bool IsTheMajorElement(int index, int[] nums, int needed) {
        int count = 1, target = nums[index];

        for(int i = index - 1; i >= 0 && nums[i] == target; i--)
            count++;
        
        for(int j = index + 1; j < nums.Length && nums[j] == target; j++)
            count++;

        return count > needed;
    }
}