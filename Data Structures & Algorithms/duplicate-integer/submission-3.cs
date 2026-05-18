public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        var dic = new Dictionary<int, int>();

        foreach(var n in nums)
        {
            if(!dic.ContainsKey(n))
            {
                dic[n] = 1;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}