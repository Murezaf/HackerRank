class Result
{
    public static string pangrams(string s)
    {
        HashSet<char> seenSet = new HashSet<char>(); s = s.ToLower();

        foreach (char c in s.ToLower())
        {
            if (c >= 'a' && c <= 'z')
                seenSet.Add(c);  
        }

        return seenSet.Count == 26 ? "pangram" : "not pangram";
    }

    //public static string pangrams(string s)
    //{
    //    Dictionary<char, bool> everSeen = new Dictionary<char, bool>(); s = s.ToLower();

    //    for (int i = 0; i < s.Length; i++)
    //    {
    //        if (s[i] >= 'a' && s[i] <= 'z')
    //        {
    //            if (!everSeen.ContainsKey(s[i]))
    //                everSeen[s[i]] = true;
    //        }
    //    }

    //    return (everSeen.Keys.Count == 26) ? "pangram" : "not pangram";
    //}

    //public static string pangrams(string s)
    //{
    //    bool[] everSeen = new bool[26]; s = s.ToLower(); int lettersCount = 0;

    //    foreach (char c in s)
    //    {
    //        if (c >= 'a' && c <= 'z')
    //        {
    //            int index = c - 'a';

    //            if (!everSeen[index])
    //            {
    //                everSeen[index] = true;
    //                lettersCount++;
    //            }
    //        }
    //    }

    //    return (lettersCount == 26) ? "pangram" : "not pangram";
    //}
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