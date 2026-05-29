public class Solution {
    public void Rotate(int[] nums, int k)
    {
        int count = 0;
        k %= nums.Length;
        
        for(int i = 0; count < nums.Length; i++)
        {
            int curIdx = i;
            int prev = nums[i];

            do
            {
                var nextIdx = (curIdx + k) % nums.Length;
                (prev, nums[nextIdx]) = (nums[nextIdx], prev);
                curIdx = nextIdx;
                count++;
            }
            while(i != curIdx);
        }
    }
}