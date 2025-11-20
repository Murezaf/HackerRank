class Result
{
    public static List<int> breakingRecords(List<int> scores)
    {
        int leastpoints_break = 0; int mostpoints_break = 0; int max = scores[0]; int min = scores[0];
        List<int> result = new List<int>();
        for (int i = 1; i < scores.Count; i++)
        {
            if(scores[i] > max)
            {
                max = scores[i];
                mostpoints_break++;
            }
            else if(scores[i] < min)
            {
                min = scores[i];
                leastpoints_break++;
            }
        }
        result.Add(mostpoints_break);
        result.Add(leastpoints_break);
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}