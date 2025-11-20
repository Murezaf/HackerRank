class Result
{
    public static void miniMaxSum(List<int> arr)
    {
        string result = "";
        if (arr.Count == 0)
            result = "0 0";
        else if (arr.Count == 1)
            result = $"{arr[0]} {arr[0]}";
        else
        {
            int min = arr[0]; int max = arr[0]; long sum = 0; //Because of max value of each elemnt in arr, sum can be greater than ints capacity

            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i];
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            result = $"{sum - max} {sum - min}";
        }
        Console.WriteLine(result);
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}