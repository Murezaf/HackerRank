//ًQ2
//Test Results : All available test cases passed
//Chat GPT was used to pass this test
class Result
{
    /*
     * Complete the 'findSmallestMissingPositive' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY orderNumbers as parameter.
     */
    public static int findSmallestMissingPositive(List<int> nums)
    {
        int n = nums.Count;

        for (int i = 0; i < n; i++)
        {
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i]) //is there any need to swap?
            //if it is positive and equal or less than n and we don't have another of this number in their correct index(cause it will make an infinite loop) => we need to swap
            {
                int correctIndex = nums[i] - 1;
                int temp = nums[i];
                nums[i] = nums[correctIndex];
                nums[correctIndex] = temp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (nums[i] != i + 1)
                return i + 1;
        }

        return n + 1;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int orderNumbersCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> orderNumbers = new List<int>();

        for (int i = 0; i < orderNumbersCount; i++)
        {
            int orderNumbersItem = Convert.ToInt32(Console.ReadLine().Trim());
            orderNumbers.Add(orderNumbersItem);
        }

        int result = Result.findSmallestMissingPositive(orderNumbers);

        Console.WriteLine(result);
    }
}
