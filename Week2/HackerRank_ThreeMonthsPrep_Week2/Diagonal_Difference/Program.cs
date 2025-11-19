class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        int n = arr.Count;
        int leftToRight = 0;
        int rightToLeft = 0;

        for (int i = 0; i < n; i++)
        {
            leftToRight += arr[i][i];
            rightToLeft += arr[i][n - i - 1];
        }
        return Math.Abs(leftToRight - rightToLeft);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}