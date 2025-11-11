//Q7
//Test Results : All available test cases passed
class Result
{
    /*
     * Complete the 'maximizeNonOverlappingMeetings' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY meetings as parameter.
     */

    public static int maximizeNonOverlappingMeetings(List<List<int>> meetings)
    {
        List<List<int>> result = new List<List<int>>();
        meetings.Sort((a, b) => a[1].CompareTo(b[1]));
        result.Add(meetings[0]);
        foreach (List<int> meet in meetings)
        {
            if (meet[0] >= result[result.Count() - 1][1])
            {
                result.Add(meet);
            }
        }
        return result.Count();
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        int meetingsRows = Convert.ToInt32(Console.ReadLine().Trim());
        int meetingsColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> meetings = new List<List<int>>();

        for (int i = 0; i < meetingsRows; i++)
        {
            meetings.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(meetingsTemp => Convert.ToInt32(meetingsTemp)).ToList());
        }

        int result = Result.maximizeNonOverlappingMeetings(meetings);

        Console.WriteLine(result);
    }
}