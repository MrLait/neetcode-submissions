public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return string.Empty;

        var prefix = new StringBuilder();
        int minLen = strs[0].Length;

        for(int k = 1; k < strs.Length; k++)
            minLen = Math.Min(minLen, strs[k].Length);

        if(minLen == 0) 
            return string.Empty;

        for(int j = 0; j < minLen; j++)
        {
            var cur  = strs[0][j];
            
            for(var i = 0; i < strs.Length; i++)
            {
                if (strs[i][j] != cur)
                    return prefix.ToString();
            }
            
            prefix.Append(cur);
        }

        return prefix.ToString();
    }
}