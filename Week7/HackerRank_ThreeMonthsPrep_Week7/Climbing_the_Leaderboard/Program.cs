class Result
{
    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        List<int> uniqueRanked = ranked.Distinct().ToList(); List<int> result = new List<int>();

        int i = uniqueRanked.Count - 1;
        foreach (int score in player)
        {
            while (i >= 0 && score >= uniqueRanked[i])
            {
                i--;
            }
            result.Add(i + 2);
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

        int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

        List<int> result = Result.climbingLeaderboard(ranked, player);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}