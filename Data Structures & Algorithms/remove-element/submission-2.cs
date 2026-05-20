public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        var ptr1 = 0;
        var k = 0;

        for(int i = ptr1; i < nums.Length; i++)
        {
            if(nums[i] != val) 
            {
                ptr1 = i + 1;    
                k++; 
                continue;
            }

            for(var j = i + 1; j < nums.Length; j++)
            {
                if(nums[j] != val)
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                    k++;
                    break;
                }
            }
        }
        
        return k;
    }
}