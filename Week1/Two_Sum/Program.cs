//Q15
//Test Results : All available test cases passed
class Result
{
    /*
     * Complete the 'findTaskPairForSlot' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY taskDurations
     *  2. INTEGER slotLength
     */

    public static List<int> findTaskPairForSlot(List<int> taskDurations, int slotLength)
    {
        List<int> result = new List<int>();
        Dictionary<int, int> nums = new Dictionary<int, int>();
        int temp = 0;
        for (int i = 0; i < taskDurations.Count; i++)
        {
            temp = slotLength - taskDurations[i];
            if (nums.ContainsKey(temp))
            {
                nums.TryGetValue(temp, out int j);
                result.Add(j);
                result.Add(i);
                return result;
            }
            else
            {
                nums[taskDurations[i]] = i;
            }
        }
        result.Add(-1);
        result.Add(-1);
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int taskDurationsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> taskDurations = new List<int>();

        for (int i = 0; i < taskDurationsCount; i++)
        {
            int taskDurationsItem = Convert.ToInt32(Console.ReadLine().Trim());
            taskDurations.Add(taskDurationsItem);
        }

        int slotLength = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> result = Result.findTaskPairForSlot(taskDurations, slotLength);

        Console.WriteLine(String.Join("\n", result));
    }
}