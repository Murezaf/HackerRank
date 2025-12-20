class Result
{
    public static string balancedSums(List<int> arr)
    {
        int temp = 0; int sum = 0;

        foreach (int i in arr)
            sum += i;

        if (sum - arr[0] == 0 || sum - arr[arr.Count - 1] == 0)
            return "YES";

        for (int i = 0; i < arr.Count - 1; i++)
        {
            temp += arr[i];
            if (temp == sum - temp - arr[i + 1])
                return "YES";
        }

        return "NO";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string result = Result.balancedSums(arr);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}