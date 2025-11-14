//Q15
//Test Results : All available test cases passed
class Result
{
    public static List<int> findTaskPairForSlot(List<int> taskDurations, int slotLength)
    {
        Dictionary<int, int> nums = new Dictionary<int, int>();
        int temp = 0;
        for (int i = 0; i < taskDurations.Count; i++)
        {
            temp = slotLength - taskDurations[i];
            if (nums.ContainsKey(temp))
            {
                nums.TryGetValue(temp, out int j);
                return new List<int>() { j, i };
            }
            else
            {
                nums[taskDurations[i]] = i;
            }
        }
        return new List<int>() { -1, -1 };
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