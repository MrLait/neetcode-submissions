public class Solution {
    public int MaxProfit(int[] prices)
    {
        var result = 0;

        for(int i = 1; i < prices.Length; i++)
        {
            if(prices[i] > prices[i - 1])
                result += prices[i] - prices[i - 1];
        }

        return result;
    }
}