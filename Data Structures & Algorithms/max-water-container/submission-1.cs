public class Solution {
    public int MaxArea(int[] heights)
    {
        int maxArea = 0, area = 0;
        int l = 0, r = heights.Length - 1;

        while(l < r)
        {
            var width = r - l;
            var minHeight = Math.Min(heights[l], heights[r]);
            area = minHeight * width;
            maxArea = Math.Max(area, maxArea);

            if(heights[l] <= heights[r])
                l++;
            else
                r--;
        }

        return maxArea;
    }
}
