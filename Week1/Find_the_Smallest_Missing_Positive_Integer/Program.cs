//ًQ2
//Test Results : All available test cases passed
class Result
{
    public static int findSmallestMissingPositive(List<int> nums)
    {
        int len = nums.Count;

        for (int i = 0; i < len; i++)
        {
            while (nums[i] > 0 && nums[i] <= len && nums[nums[i] - 1] != nums[i])//Is there any need to swap in this step?
            //If it is positive(we want to put positive numbers to their correct position) and equal or less than n and we don't have another of this number in the correct index(cause it will make an infinite loop) => Swapping must be done 
            {
                int correctIndex = nums[i] - 1;
                int temp = nums[i];
                nums[i] = nums[correctIndex];
                nums[correctIndex] = temp;
            }
        }

        for (int i = 0; i < len; i++)
        {
            if (nums[i] != i + 1)
                return i + 1;
        }

        return len + 1;
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

/*
An example: nums = [3, 4, 3, -1, 1]
Step i=0:
    nums[0] = 3 → should be at index 2
    nums[2] = 3  → same value, so no swap (to avoid infinite loop)
    → move to next i

Step i=1:
    nums[1] = 4 → should be at index 3
    swap: [3, 4, 3, -1, 1] → [3, -1, 3, 4, 1]
    Now nums[1] = -1 (not positive) → stop while

Step i=2:
    nums[2] = 3 → already in correct place (index2)

Step i=3:
    nums[3] = 4 → already correct (index3)

Step i=4:
    nums[4] = 1 → correct index = 0
    swap(nums[4], nums[0]) → [1, -1, 3, 4, 3]

Final array after rearrangement:
    [1, -1, 3, 4, 3]

Scan from start:
    index 0 → value 1 ✅
    index 1 → value -1 ❌ (expected 2)
→ smallest missing positive = 2
*/

/*
Although there's a 'while' inside a 'for', the total time complexity is still linear.

Reason:
- Each iteration of 'while' moves one element to its correct place (index = value - 1).
- Once an element is placed correctly, it never gets moved again.
- Hence, each element can be swapped at most once.
- The total number of swaps across the entire loop ≤ n.

So even though we have nested loops, the number of operations grows with n, not n².
*/