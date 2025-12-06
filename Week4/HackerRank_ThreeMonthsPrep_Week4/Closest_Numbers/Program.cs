class Result
{
    public static List<int> closestNumbers(List<int> arr)
    {
        int min_defference = int.MaxValue; List<int> result = new List<int>();
        arr.Sort();
        
        for (int i = arr.Count - 1; i > 0; i--)
        {
            if (arr[i] - arr[i - 1] < min_defference)
                min_defference = arr[i] - arr[i - 1];
        }

        for (int i = 0; i < arr.Count - 1; i++)
        {
            if (arr[i + 1] - arr[i] == min_defference)
            {
                result.Add(arr[i]);
                result.Add(arr[i + 1]);
            }
        }

        return result;
    }
}
//First we sort the array because after sorting, the smallest absolute difference can only occur between neighboring elements. By doing this we avoid checking all possible pairs (O(n^2)) and only compare adjacent pairs (O(n)).

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.closestNumbers(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}