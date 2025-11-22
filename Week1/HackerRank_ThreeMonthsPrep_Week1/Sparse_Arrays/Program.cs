class Result
{
    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        var dictionary = new Dictionary<string, int>(); List<int> result = new List<int>();

        foreach (string s in strings)
        {
            if (!dictionary.ContainsKey(s))
                dictionary[s] = 0;
            dictionary[s]++;
        }

        foreach (string query in queries)
            result.Add(dictionary.ContainsKey(query) ? dictionary[query] : 0);

        return result;
    }
    // Time Complexity: O(n + q)
    // O(n): building frequency map of strings
    // O(q): checking each query in the map
    // Space Complexity: O(n) for the dictionary

    //public static List<int> matchingStrings(List<string> strings, List<string> queries)
    //{
    //    List<int> result = new List<int>();
    //    for (int i = 0; i < strings.Count; i++)
    //    {
    //        int count = 0;
    //        for (int j = 0; j < queries.Count; j++)
    //        {
    //            if (strings[i]  == queries[j])
    //                count++;
    //        }
    //        result.Add(count);
    //    }
    //    return result;
    //}
    // Time Complexity: O(n * q)
    // Space Complexity: O(q) — only the results list is stored
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> strings = new List<string>();

        for (int i = 0; i < stringsCount; i++)
        {
            string stringsItem = Console.ReadLine();
            strings.Add(stringsItem);
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> queries = new List<string>();

        for (int i = 0; i < queriesCount; i++)
        {
            string queriesItem = Console.ReadLine();
            queries.Add(queriesItem);
        }

        List<int> res = Result.matchingStrings(strings, queries);

        textWriter.WriteLine(String.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}