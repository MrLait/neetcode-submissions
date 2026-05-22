public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        var map = new Dictionary<char, int>();
        int result = 0, left = 0;

        for(var right = 0; right < s.Length; right++)
        {
            var c = s[right];

            if(map.ContainsKey(c) && map[c] >= left)
                left = map[c] + 1;
                
            map[c] = right;

            result = Math.Max(result, right - left + 1);
        }
        
        return result;
    }
}
