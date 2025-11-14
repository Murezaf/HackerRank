//Q1
//Test Results : All available test cases passed
class Result
{
    /*
     * Complete the 'countResponseTimeRegressions' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY responseTimes as parameter.
     */

    public static int countResponseTimeRegressions(List<int> responseTimes)
    {
        if (responseTimes.Count <= 0)
        { return 0; }
        int result = 0;
        double sum = responseTimes[0];
        for (int i = 1; i < responseTimes.Count; i++)
        {
            if (responseTimes[i] > sum / i)
            {
                result++;
            }
            sum += responseTimes[i];
        }
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int responseTimesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> responseTimes = new List<int>();

        for (int i = 0; i < responseTimesCount; i++)
        {
            int responseTimesItem = Convert.ToInt32(Console.ReadLine().Trim());
            responseTimes.Add(responseTimesItem);
        }

        int result = Result.countResponseTimeRegressions(responseTimes);

        Console.WriteLine(result);
    }
}