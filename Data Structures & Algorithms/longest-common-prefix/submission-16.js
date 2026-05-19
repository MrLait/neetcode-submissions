class Solution {
    /**
     * @param {string[]} strs
     * @return {string}
     */
    longestCommonPrefix(strs) {
        let prefix = strs[0];

        for(let i = 1; i < strs.length; i++)
        {
            let j = 0;
            for(; j < Math.min(prefix.length, strs[i].length); j++)
            {
                if(prefix[j] != strs[i][j])
                {
                    break;
                }
            }
            
            prefix = prefix.substring(0, j);
        }

        return prefix;
    }
}
