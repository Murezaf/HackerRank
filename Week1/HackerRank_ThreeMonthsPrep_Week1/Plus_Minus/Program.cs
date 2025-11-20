class Result
{
    public static void plusMinus(List<int> arr)
    {
        decimal positives = 0m; decimal negetives = 0m; decimal zeros = 0m;
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] == 0)
                zeros++;
            else if (arr[i] < 0)
                negetives++;
            else
                positives++;
        }
        Console.WriteLine(Math.Round(positives / arr.Count, 6));
        Console.WriteLine(Math.Round(negetives / arr.Count, 6));
        Console.WriteLine(Math.Round(zeros / arr.Count, 6));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}