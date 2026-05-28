public class Solution {
    public List<int> MajorityElement(int[] nums) {
        if (nums.Length == 1)
            return [nums[0]];
            
        var result = new List<int>();
        var times = nums.Length / 3;
        Array.Sort(nums);

        if (IsTheMajorElement(times, nums, times))
            result.Add(nums[times]);

        if (nums[times] != nums[nums.Length - times - 1] &&
            IsTheMajorElement(nums.Length - times - 1, nums, times))
            result.Add(nums[nums.Length - times - 1]);

        return result;
    }

    private bool IsTheMajorElement(int index, int[] nums, int needed) {
        var j = index + 1;
        var i = index - 1;
        var count = 1;

        while ((i >= 0 || j < nums.Length) && count <= needed) {
            if (j < nums.Length && nums[index] == nums[j])
                count++;

            if (i >= 0 && nums[index] == nums[i])
                count++;

            if (count > needed)
                return true;

            j++;
            i--;
        }

        return count > needed;
    }
}