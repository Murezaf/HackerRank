class Result
{
    public static List<int> countingSort(List<int> arr)
    {
        List<int> numberof_occurs = new List<int>();
        for (int i = 0; i < 100; i++)
            numberof_occurs.Add(0);

        for (int i = 0; i < arr.Count; i++)
        {
            numberof_occurs[arr[i]]++;
        }

        return numberof_occurs;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.countingSort(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}