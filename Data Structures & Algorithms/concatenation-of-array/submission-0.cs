public class Solution {
    public int[] GetConcatenation(int[] nums)
    {
        var result = new int[nums.Length * 2];
        var n = 0;
        var j = 0;

        while(n < 2)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                result[j] = nums[i];
                j++;
            }

            n++;
        }

        return result;
    }
}