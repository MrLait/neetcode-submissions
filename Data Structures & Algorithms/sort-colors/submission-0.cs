public class Solution {
    public void SortColors(int[] nums) {
        if(nums.Length <= 1) return;

        var sorted = MergeSort(nums);
        Array.Copy(sorted, nums, nums.Length);
    }

    private int[] MergeSort(int[] nums){
        if(nums.Length <= 1) return nums;

        var mid = nums.Length / 2;
        var left = MergeSort(nums[..mid]);
        var right = MergeSort(nums[mid..]);

        return Merge(left, right);
    }

    private int[] Merge(int[] a, int[] b){
        var res = new int[a.Length + b.Length];
        int i = 0, j = 0, k = 0;

        while(i < a.Length && j < b.Length)
        {
            if(a[i] <= b[j])
                res[k++] = a[i++];
            else
                res[k++] = b[j++];
        }

        while(i < a.Length)
            res[k++] = a[i++];

        while(j < b.Length)
            res[k++] = b[j++];
        
        return res;
    }
}