class Result
{
    public static int marsExploration(string s)
    {
        int numberOfChanges = 0; string pattern = "SOS";

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != pattern[i % 3])
                numberOfChanges++;
        }

        return numberOfChanges;
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