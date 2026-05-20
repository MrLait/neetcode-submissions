class Solution {
    /**
     * @param {number[]} nums
     * @return {void} Do not return anything, modify nums in-place instead.
     */
    sortColors(nums) {
        let low = 0, mid = 0, high = 0;
        for(const n of nums)
        {
            if(n == 0)
                low++;
            if(n == 1)
                mid++;
            if(n==2)
                high++;
        }

        let i = 0;
        while(low-- > 0) nums[i++] = 0;
        while(mid-- > 0) nums[i++] = 1;
        while(high-- > 0) nums[i++] = 2;
    
    }
}
