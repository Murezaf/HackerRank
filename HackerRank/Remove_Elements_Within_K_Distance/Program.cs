//Q14
//Test Results : All available test cases passed
class Result
{
    /*
     * Complete the 'debounceTimestamps' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY timestamps
     *  2. INTEGER K
     */

    public static int debounceTimestamps(List<int> timestamps, int K)
    {
        int i = 1;
        int temp = 0;
        while (i < timestamps.Count)
        {
            temp = timestamps[i] - timestamps[i - 1];
            if (temp >= K)
            {
                i++;
            }
            else
            {
                timestamps.RemoveAt(i);
            }
        }
        return timestamps.Count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int timestampsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> timestamps = new List<int>();

        for (int i = 0; i < timestampsCount; i++)
        {
            int timestampsItem = Convert.ToInt32(Console.ReadLine().Trim());
            timestamps.Add(timestampsItem);
        }

        int K = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.debounceTimestamps(timestamps, K);

        Console.WriteLine(result);
    }
}
