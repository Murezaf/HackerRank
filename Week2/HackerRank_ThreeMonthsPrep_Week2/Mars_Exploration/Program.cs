class Result
{
    public static int marsExploration(string s)
    {
        int changes = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char expected;

            if (i % 3 == 0 || i % 3 == 2)
                expected = 'S';
            else
                expected = 'O';

            if (s[i] != expected)
                changes++;
        }

        return changes;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.marsExploration(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}