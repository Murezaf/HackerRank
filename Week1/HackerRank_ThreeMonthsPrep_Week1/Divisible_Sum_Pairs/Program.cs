class Result
{
    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int[] remainders = new int[k];
        int count = 0;
        for (int i = 0; i < n; i++) //remainders[i] = the number of elements in ar, which their remainder when divided by k is i

        {
            int remainder = ar[i] % k;
            remainders[remainder]++;
        }

        count += remainders[0] * (remainders[0] - 1) / 2; //they make k with eachother(among their selves) and not with other numbers with another remainders. for example: 15&5 for k = 5 and they both have 0 as their remainder

        if (k % 2 != 0)
        {
            for (int i = 1; i <= k / 2; i++)
            {
                if (i != k - i)
                    count += remainders[i] * remainders[k - i]; //each pair of elements with remainders[i] and remainders[k - i] counts for our target
            }
        }

        if (k % 2 == 0)
        {
            for (int i = 1; i < k / 2; i++)
            {
                if (i != k - i)
                    count += remainders[i] * remainders[k - i];
            }
            count += remainders[k / 2] * (remainders[k / 2] - 1) / 2; //exactly like remainder 0 we had before: they make k with eachother(among their selves) and not with other numbers with another remainders. for example: 4&12 for k = 8 and they both have 4 as their remainder
        }
        return count;
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