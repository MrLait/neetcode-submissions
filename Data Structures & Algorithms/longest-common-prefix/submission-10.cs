public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        if(strs[0].Length == 0) 
            return string.Empty;

        var prefix = new StringBuilder();
        
        int minLen = strs[0].Length;

        for(int j = 0; j < minLen; j++)
        {
            var cur  = strs[0][j];
            
            for(var i = 0; i < strs.Length; i++)
            {
                if(j == 0)
                {
                    minLen = Math.Min(minLen, strs[i].Length);
                    if(minLen == 0) 
                        return string.Empty;
                }

                if (strs[i][j] != cur)
                    return prefix.ToString();
            }
            
            prefix.Append(cur);
        }

        return prefix.ToString();
    }
}