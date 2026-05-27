public class Solution {
    public int MaxProfit(int[] prices)
    {
        var result = 0;
        var maxProfit = 0;
        var minPrice = int.MaxValue;
        var prev = prices[0];

        for(int i = 1; i < prices.Length; i++)
        {
            if(prev > prices[i])
            {
                prev = prices[i];
                result += maxProfit;
                maxProfit = 0;
                minPrice = int.MaxValue;
                continue;
            }

            if(prev < prices[i])
            {
                minPrice = Math.Min(minPrice, prev);
                maxProfit = Math.Max(prices[i] - minPrice, maxProfit);
                prev = prices[i];
            }
        }
        
        result += maxProfit;
        return result;
    }
}