public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        var map = new Dictionary<char, int>();
        var result = 0;

        for(var i = 0; i < s.Length; i++)
        {
            if(!map.TryAdd(s[i], i))
            {
                result = Math.Max(result, map.Count());
                i = map[s[i]];
                map = new Dictionary<char, int>();
            }
        }
        
        result = Math.Max(result, map.Count());
        return result;
    }
}
