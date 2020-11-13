using System;

namespace _34.Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 8, 4, 6, 2, 3 };

            foreach (int P in FinalPrices(prices))
            {
                Console.WriteLine(P);
            }
        }

        static int[] FinalPrices(int[] prices)
        {
            int[] result = prices;
            for (int P = 0; P < prices.Length; P++)
            {
                for (int T = P+1; T < prices.Length; T++)
                {
                    if (prices[P] >= prices[T])
                    {
                        result[P] = prices[P] - prices[T];
                        T = prices.Length;
                    }
                }
            }
            return result;
        }
    }
}
