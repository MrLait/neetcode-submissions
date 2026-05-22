public class Solution {
    public int MaxArea(int[] heights)
    {
        var pointerL = new int[2];
        var pointerR = new int[2];
        int maxAmount = 0, curAmount = 0;
        int i = 0, j = heights.Length - 1;

        (pointerL[0], pointerL[1]) = (i, heights[i]);
        (pointerR[0], pointerR[1]) = (j, heights[j]);

        while(i < j)
        {
            var width = j - i;
            curAmount = pointerL[1] < pointerR[1] ? pointerL[1] * width : pointerR[1] * width;
            maxAmount = Math.Max(curAmount, maxAmount);

            if(pointerL[1] <= pointerR[1])
            {
                i++;
                (pointerL[0], pointerL[1]) = (i, heights[i]);
            }
            else
            {
                j--;
                (pointerR[0], pointerR[1]) = (j, heights[j]);
            }
        }

        return maxAmount;
    }
}
