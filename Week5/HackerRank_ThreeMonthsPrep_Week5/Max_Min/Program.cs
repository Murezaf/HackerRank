class Result
{
    public static int maxMin(int k, List<int> arr)
    {
        arr.Sort(); int minUnfairness = int.MaxValue; int unfairness = 0;

        for (int i = 0; i < arr.Count - k + 1; i++)
        {
            unfairness = arr[i + k - 1] - arr[i];

            if (unfairness < minUnfairness)
                minUnfairness = unfairness;
        }

        return minUnfairness;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            arr.Add(arrItem);
        }

        int result = Result.maxMin(k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}