class Result
{
    public static string pangrams(string s)
    {
        bool[] seen = new bool[26];
        s = s.ToLower();
        int lettersCount = 0;

        foreach (char c in s)
        {
            if (c >= 'a' && c <= 'z')
            {
                int index = c - 'a';
                if (!seen[index])
                {
                    seen[index] = true;
                    lettersCount++;
                }
            }
        }
        return (lettersCount == 26) ? "pangram" : "not pangram";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}