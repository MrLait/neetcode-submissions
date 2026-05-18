public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        var dic = new Dictionary<int, int>();

        foreach(var n in nums)
        {
            if(!dic.TryAdd(n,1))
                return true;
        }

        return false;
    }
}