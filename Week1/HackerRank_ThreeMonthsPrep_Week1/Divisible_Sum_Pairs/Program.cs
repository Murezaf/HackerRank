class Result
{
    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int[] remainders = new int[k]; //remainders[i] stores how many elements in 'ar' have a remainder of 'i' in dividing by k

        foreach (int number in ar)
            remainders[number % k]++;

        int pairs = 0;
        pairs += CombinationCount(remainders[0]); //All numbers with remainder 0 can pair with each other

        int limit = k / 2;

        if (k % 2 == 0)
        {
            for (int r = 1; r < limit; r++)
                pairs += remainders[r] * remainders[k - r];

            pairs += CombinationCount(remainders[limit]); //For even k, when remainder is k/2, it can only pair with each other
        }
        else
        {
            for (int r = 1; r <= limit; r++)
                pairs += remainders[r] * remainders[k - r];
        }

        return pairs;
    }

    private static int CombinationCount(int count)
    {
        return count * (count - 1) / 2;
    }
    // Time Complexity: O(n + k)
    // - O(n): find and counting remainders in the first loop
    // - O(k): combining remainder pairs
    // Space Complexity: O(k) for the remainders array

    //public static int divisibleSumPairs(int n, int k, List<int> ar)
    //{
    //    int count = 0;
    //    for (int i = 0; i < n; i++)
    //    {
    //        for (int j = i + 1; j < n; j++)
    //        {
    //            if ((ar[i] + ar[j]) % k == 0)
    //                count++;
    //        }
    //    }
    //    return count;
    //}
    // Time Complexity: O(n²)
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.divisibleSumPairs(n, k, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}