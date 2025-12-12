class Result
{
    public static int birthday(List<int> s, int d, int m)
    {
        int sum = 0; int result = 0;
        for (int i = 0; i < m; i++)
        {
            sum += s[i];
        }

        if (sum == d)
            result++;

        for (int i = 0; i < s.Count - m; i++)
        {
            sum -= s[i];
            sum += s[i + m];
            if (sum == d)
                result++;
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.birthday(s, d, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}