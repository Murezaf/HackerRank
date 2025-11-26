class Result
{
    public static List<int> maximumPerimeterTriangle(List<int> sticks)
    {
        sticks.Sort();
     
        for (int i = sticks.Count - 1; i >= 2; i--)
        {
            if (sticks[i] < sticks[i-1] + sticks[i-2])
            {
                return new List<int>() { sticks[i-2], sticks[i-1], sticks[i] };
            }
        }

        return new List<int>() { -1 };
    }
}
/* Don't need to check all C(n,3) triplets because after sorting the array, if sticks[i], sticks[i-1], sticks[i-2] don't form a triangle, then sticks[i] cannot form a triangle with any smaller ones. 
 * This eliminates all combinations containing sticks[i], reducing the search from O(n^3) to a simple linear scan from the end.*/
//The tie-breaking rules are satisfied automatically in this greedy approach.

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> sticks = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sticksTemp => Convert.ToInt32(sticksTemp)).ToList();

        List<int> result = Result.maximumPerimeterTriangle(sticks);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}