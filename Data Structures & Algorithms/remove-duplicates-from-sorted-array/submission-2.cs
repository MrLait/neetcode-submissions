public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        int k = 1, slow = 0;

        for(int fast = 1; fast < nums.Length; fast++)
        {
            if(nums[slow] != nums[fast])
            {
                k++;
                slow++;
                nums[slow] = nums[fast];
            }
        }
        
        return k;
    }
}