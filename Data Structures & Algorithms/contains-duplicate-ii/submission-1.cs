public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                if(Math.Abs(map[nums[i]] - i) <= k)
                    return true;
                else
                    map[nums[i]] = i;
            }
            else
            {
                map[nums[i]] = i;
            }
        }

        return false;
    }
}