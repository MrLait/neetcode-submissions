public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x)
    {
        if(arr.Length <= k) return arr.ToList();
        int closestSumMin = int.MaxValue, closestSum = 0, left = 0, right = 0;

        while(right < k)
            closestSum += Math.Abs(arr[right++] - x);

        closestSumMin = closestSum;

        for(; right < arr.Length; right++)
        {
            closestSum -= Math.Abs(arr[right - k] - x);
            closestSum += Math.Abs(arr[right] - x);

            if(closestSum < closestSumMin)
            {
                closestSumMin = closestSum;
                left = right - k + 1;
            }
        }

        return arr[left..(left + k)].ToList();
    }
}