public class Solution {
    public int SubarraySum(int[] nums, int k)
    {
        var map = new Dictionary<int, int>();
        int curSum = 0, result = 0;
        map[0] = 1;

        foreach(var num in nums)
        {
            curSum += num;
            var diff = curSum - k;

            result += map.GetValueOrDefault(diff);
            map[curSum] = map.GetValueOrDefault(curSum) + 1;
        }    

        return result;
    }
}