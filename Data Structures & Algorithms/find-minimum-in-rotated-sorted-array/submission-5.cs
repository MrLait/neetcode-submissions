public class Solution {
    public int FindMin(int[] nums)
    {
        int l = 0, r = nums.Length - 1, m = 0;

        while(l <= r)
        {
            m = l + (r - l) / 2;
            Console.WriteLine(nums[m]);
            if(nums[m] >= nums[l])
            {
                if(nums[l] > nums[r])
                {
                    Console.WriteLine($"l = {nums[l]}");
                    l = m + 1;
                }
                else
                    return nums[l];
            }
            else
            {
                Console.WriteLine("asd");
                // if(nums[m] > )
                // {
                    if(nums[l] > nums[r])
                    {
                        r = m;
                    }
                    else
                    {
                        r = m;
                    }
                // }
            }
        }

        return nums[m];
    }
}
