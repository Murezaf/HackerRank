//Q5
//Test Results : All available test cases passed
class Result
{
    public static int binarySearch(List<int> nums, int target)
    {
        return search(nums, 0, nums.Count - 1, target); 
    }

    private static int search(List<int> nums, int low, int high, int target)//To avoid losing the first string, we created this method with low and high.(We need indexes for the very first string at the end.)
    {
        if (low > high)
            return -1;

        int mid = (low + high)/ 2;

        if (nums[mid] == target)
            return mid;
        else if (nums[mid] < target)
            return search(nums, mid + 1, high, target);
        else
            return search(nums, low, mid - 1, target);
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

        int result = Result.binarySearch(nums, target);

        Console.WriteLine(result);
    }
}