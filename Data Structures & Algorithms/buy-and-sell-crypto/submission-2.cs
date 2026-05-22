public class Solution {
    public int MaxProfit(int[] prices)
    {
        var prev = prices[0];
        int maxProfit = 0, profit = 0;

        for(int i = 1; i < prices.Length; i++)
        {
            if(prev > prices[i])
                prev = prices[i];
            else
            {
                profit = prices[i] - prev;
                maxProfit = Math.Max(profit, maxProfit);
            }
            
        }    

        return maxProfit;
    }
}
