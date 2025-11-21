class Result
{
    public static List<int> QuickSort(List<int> arr)
    {
        if (arr.Count <= 1)
            return arr;

        int pivot = arr[arr.Count / 2];
        List<int> lessthan_pivot = new List<int>();
        List<int> equalto_pivot = new List<int>();
        List<int> greaterthan_pivot = new List<int>();

        foreach (int i in arr)
        {
            if (i > pivot)
                greaterthan_pivot.Add(i);
            else if (i < pivot)
                lessthan_pivot.Add(i);
            else
                equalto_pivot.Add(i);
        }

        List<int> result = new List<int>();
        result.AddRange(QuickSort(lessthan_pivot));
        result.AddRange(equalto_pivot);
        result.AddRange(QuickSort(greaterthan_pivot));

        return result;
    }

    public static List<int> ReverseSortedList(List<int> nums)
    {
        int temp = 0; int length = nums.Count;
        for (int i = 0; i < length/2; i++)
        {
            nums[i] = temp;
            nums[i] = nums[length - i - 1];
        }
        return nums;
    }

    public static string twoArrays(int k, List<int> A, List<int> B)
    {
        A = QuickSort(A);
        B = QuickSort(B);
        B = ReverseSortedList(B);

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] + B[i] < k)
                return "NO";
        }
        return "YES";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

            List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

            string result = Result.twoArrays(k, A, B);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}