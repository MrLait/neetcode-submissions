public class Solution {
    public int MajorityElement(int[] nums)
    {
        Array.Sort(nums);    
        var result = nums[0];
        var cnt = 0;
        var maxCnt = 0;
        
        for(int i = 0; i < nums.Length - 1; i++)
        {
            if(nums[i] == nums[i + 1])
                cnt++;
            else
            {
                if(cnt > maxCnt)
                {
                    result = nums[i];
                    maxCnt = cnt;
                    cnt = 0;
                }
            }
        }

        return cnt > maxCnt ? nums[nums.Length - 1] : result;
    }
}