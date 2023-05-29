using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    // https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    class E_StockBuyAndSell
    {
        int[] prices;
        public E_StockBuyAndSell(int[] prices)
        {
            this.prices = prices;
        }
        public void MaximumProfit()
        {
            int maxProfit = 0;
            int minCost = prices[0];
            for (int i = 0; i < prices.Length; i++)
            {
                minCost = Math.Min(prices[i], minCost);
                maxProfit = Math.Max(maxProfit, prices[i] - minCost);
            }
            Console.WriteLine(maxProfit);
        }
    }
}
