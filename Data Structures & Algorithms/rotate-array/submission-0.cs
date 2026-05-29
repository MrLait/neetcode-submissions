public class Solution {
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }
    
    private void Reverse(int[] nums, int startIdx, int endIdx)
    {
        while(startIdx < endIdx)
        {
            (nums[startIdx], nums[endIdx]) = (nums[endIdx], nums[startIdx]);
            startIdx++;
            endIdx--;
        }
    }
}