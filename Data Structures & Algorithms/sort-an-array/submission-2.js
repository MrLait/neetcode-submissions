class Solution {
    /**
     * @param {number[]} nums
     * @return {number[]}
     */
    sortArray(nums) {
        if(nums.length <= 1)
            return nums;
        
        return this.mergeSort(nums);
    }

     mergeSort(nums){
        if(nums.length <= 1) 
            return nums;
        
        const mid = nums.length >> 1;
        const left = this.mergeSort(nums.slice(0, mid));
        const right = this.mergeSort(nums.slice(mid));

        return this.merge(left, right);
    }

    merge(a, b){
        let res = new Array(a.length + b.length);
        let i = 0, j = 0, k = 0;

        while(i < a.length && j < b.length)
        {
            if(a[i]  <= b[j])
                res[k++] = a[i++];
            else
                res[k++] = b[j++];
        }

        while (i < a.length){
            res[k++] = a[i++];
        }

        while (j < b.length){
            res[k++] = b[j++];
        }

        return res;
    }
}