public class Solution {
    public int FindDuplicate(int[] nums)
    {
        for(int i = 0; i < nums.Length; i++)
        {
            var index = Math.Abs(nums[i]) - 1; 
            if(nums[index] < 0)
                return Math.Abs(nums[i]);
            
            nums[index] = -nums[index]; 
        }

        return -1;
    }
}
