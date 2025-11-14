//Q11
//Test Results : All available test cases passed
class Result
{
    public static int countAffordablePairs(List<int> prices, int budget)
    {
        int count = 0;
        int left = 0;
        int right = prices.Count - 1;

        while (left < right)
        {
            if (prices[left] + prices[right] <= budget)
            {
                count += (right - left);
                left++;
            }
            else
            {
                right--;
            }
        }

        return count;
    }
    //Time complexity: O(n)

    //public static int countAffordablePairs(List<int> prices, int budget)
    //{
    //    int count = 0;
    //    for (int i = 0; i < prices.Count; i++)
    //    {
    //        for (int j = i + 1; j < prices.Count; j++)
    //        {
    //            if (prices[i] + prices[j] <= budget)
    //            {
    //                count++;
    //            }
    //        }
    //    }
    //    return count;
    //}
    //Time complexity: O(n²)
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