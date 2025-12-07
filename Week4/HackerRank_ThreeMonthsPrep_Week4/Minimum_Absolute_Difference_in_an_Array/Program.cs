class Result
{
    public static int minimumAbsoluteDifference(List<int> arr)
    {
        arr.Sort(); int min_difference = int.MaxValue;
        for (int i = 0; i < arr.Count-1; i++)
        {
            int current_difference = arr[i+1] - arr[i];
            if(current_difference < 0)
                current_difference *= -1;
            if (current_difference < min_difference)
                min_difference = current_difference;
        }
        return min_difference;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.minimumAbsoluteDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}