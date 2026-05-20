class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs)
    {
        const result = new Map();

        for(let str of strs)
        {
            const sortedStr = str.split('').sort().join('');

            if(result.has(sortedStr))
                result.get(sortedStr).push(str);
            else
                result.set(sortedStr, [str]);
        }

        return Array.from(result.values());
    }
}
