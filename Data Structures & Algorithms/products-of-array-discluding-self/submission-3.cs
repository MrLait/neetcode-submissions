public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];
        var prefix = 1;
        
        result[0] = 1;
        for(int i = 1; i < nums.Length; i++)
        {
            prefix *= nums[i-1];
            result[i] = prefix;
        }    

        var postfix = 1;
        for(int i = nums.Length - 2; i >= 0; i--)
        {
            postfix *= nums[i + 1];
            result[i] *= postfix;
        }
        
        return result;
    }
}
