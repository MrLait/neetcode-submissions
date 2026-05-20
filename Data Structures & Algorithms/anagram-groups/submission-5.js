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
            {
                let values = result.get(sortedStr);
                values.push(str);
            }
            else
            {
                result.set(sortedStr, [str]);
            }
        }

        return Array.from(result.values());
    }
}
