public class Solution {
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0, minPrice = prices[0];

        for(int i = 1; i < prices.Length; i++)
        {
            minPrice = Math.Min(minPrice, prices[i]);
            maxProfit = Math.Max(prices[i] - minPrice, maxProfit);
            
        }    

        return maxProfit;
    }
}
