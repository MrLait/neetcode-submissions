public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int mult = 1;
        int zeroCount = 0;

        foreach (var n in nums)
        {
            if (n == 0) zeroCount++;
            else        mult *= n;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (zeroCount >= 2)
                nums[i] = 0;
            else if (zeroCount == 1)
                nums[i] = (nums[i] == 0) ? mult : 0;
            else
                nums[i] = mult / nums[i];
        }

        return nums;
    }
}