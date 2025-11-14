//Q14
//Test Results : All available test cases passed
class Result
{
    // In-place removal using two-pointer.
    // O(n) time, O(1) extra space.
    public static int debounceTimestamps(List<int> timestamps, int K)
    {
        if (timestamps.Count == 0)
            return 0;

        int left = 0;
        for (int right = 1; right < timestamps.Count; right++)
        {
            if (timestamps[right] - timestamps[left] >= K)
            {
                left++;
                timestamps[left] = timestamps[right];
            }
        }
        return ++left;//First add one to left, then return it(return left++; is opposite: first return then add one)
        /*
        left++;
        return left;
        */
        //Our result list will be from index 0 to index 'left'
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