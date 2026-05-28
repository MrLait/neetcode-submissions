public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        int slow = 1;

        for(int fast = 1; fast < nums.Length; fast++)
        {
            if(nums[fast] != nums[fast - 1])
            {
                nums[slow] = nums[fast];
                slow++;
            }
        }

        return slow;
    }
}