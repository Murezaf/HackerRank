//Q11
//Test Results : All available test cases passed
class Result
{
    /*
     * Complete the 'countAffordablePairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY prices
     *  2. INTEGER budget
     */

    public static int countAffordablePairs(List<int> prices, int budget)
    {
        int count = 0;
        for (int i = 0; i < prices.Count; i++)
        {
            for (int j = i + 1; j < prices.Count; j++)
            {
                if (prices[i] + prices[j] <= budget)
                {
                    count++;
                }
            }
        }
        return count;
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        int pricesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> prices = new List<int>();

        for (int i = 0; i < pricesCount; i++)
        {
            int pricesItem = Convert.ToInt32(Console.ReadLine().Trim());
            prices.Add(pricesItem);
        }

        int budget = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.countAffordablePairs(prices, budget);

        Console.WriteLine(result);
    }
}