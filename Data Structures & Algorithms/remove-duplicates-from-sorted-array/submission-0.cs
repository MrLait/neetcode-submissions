public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        int k = 0, slow = 0;

        for(int fast = 1; fast < nums.Length; fast++)
        {
            if(nums[slow] != nums[fast])
            {
                k++;
                slow++;
                nums[slow] = nums[fast];
            }
        }

        if(nums[slow] == nums[nums.Length - 1]) k++;
        
        return k;
    }
}