public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x)
    {
        if(arr.Length <= k) return arr.ToList();
        int windowSumMin = int.MaxValue, windowSum = 0, left = 0;

        for(int i = 0; i < k; i++)
            windowSum += Math.Abs(arr[i] - x);

        windowSumMin = windowSum;

        for(int right = k; right < arr.Length; right++)
        {
            windowSum -= Math.Abs(arr[right - k] - x);
            windowSum += Math.Abs(arr[right] - x);

            if(windowSum < windowSumMin)
            {
                windowSumMin = windowSum;
                left = right - k + 1;
            }
        }

        return arr[left..(left + k)].ToList();
    }
}