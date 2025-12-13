class Result
{
    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        List<List<int>> array = new List<List<int>>(); int lastAnswer = 0; int index = 0; List<int> result = new List<int>();
        for (int i = 0; i < n; i++)
            array.Add(new List<int>());

        for (int i = 0; i < queries.Count; i++)
        {
            List<int> numbers = queries[i];
            if (numbers[0] == 1)
            {
                index = (numbers[1] ^ lastAnswer) % n;
                array[index].Add(numbers[2]);
            }

            else
            {
                index = (numbers[1] ^ lastAnswer) % n;
                lastAnswer = array[index][numbers[2] % array[index].Count];
                result.Add(lastAnswer);
            }
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int q = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> result = Result.dynamicArray(n, queries);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}