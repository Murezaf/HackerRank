//Q6
//Test Results : All available test cases passed
class Result
{
    /*
     * Complete the 'findFirstOccurrence' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY nums
     *  2. INTEGER target
     */

    public static int findFirstOccurrence(List<int> nums, int target)
    {
        return find(nums, 0, nums.Count - 1, target);
    }
    public static int find(List<int> nums, int low, int high, int target)
    {
        if (low > high) { return -1; }
        int mid = (low + high) / 2;
        if (nums[mid] == target)
        {
            if (find(nums, low, mid - 1, target) == -1)
            { return mid; }
            else
            {
                return find(nums, low, mid - 1, target);
            }
        }
        else if (nums[mid] > target)
        {
            return find(nums, low, mid - 1, target);
        }
        else
        {
            return find(nums, mid + 1, high, target);
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int numsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> nums = new List<int>();

        for (int i = 0; i < numsCount; i++)
        {
            int numsItem = Convert.ToInt32(Console.ReadLine().Trim());
            nums.Add(numsItem);
        }

        int target = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.findFirstOccurrence(nums, target);

        Console.WriteLine(result);
    }
}