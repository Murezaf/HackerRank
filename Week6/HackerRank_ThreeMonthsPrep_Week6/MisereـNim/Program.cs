class Result
{
    public static string misereNim(List<int> s)
    {
        bool allOne = true; int finalXOR = 0;
        for (int i = 0; i < s.Count; i++)
        {
            if (s[i] != 1)
                allOne = false;

            finalXOR ^= s[i];
        }

        if(allOne)
        {
            if (s.Count % 2 == 0)
                return "First";
            return "Second";
        }

        if (finalXOR == 0)
            return "Second";

        return "First";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string result = Result.misereNim(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
