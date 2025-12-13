class Result
{
    public static List<int> missingNumbers(List<int> arr, List<int> brr)
    {
        List<int> result = new List<int>();
        Dictionary<int, int> arrElementsDictionary = new Dictionary<int, int>(); 
        Dictionary<int, int> brrElementsDictionary = new Dictionary<int, int>();

        foreach (int i in arr)
        {
            if (arrElementsDictionary.ContainsKey(i))
                arrElementsDictionary[i]++;
            else
                arrElementsDictionary[i] = 1;
        }

        foreach (int i in brr)
        {
            if (brrElementsDictionary.ContainsKey(i))
                brrElementsDictionary[i]++;
            else
                brrElementsDictionary[i] = 1;
        }

        foreach(int i in brrElementsDictionary.Keys)
        {
            if(!arrElementsDictionary.ContainsKey(i))
                result.Add(i);

            else if(arrElementsDictionary[i] != brrElementsDictionary[i])
                result.Add(i);
        }

        result.Sort();
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int m = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        List<int> result = Result.missingNumbers(arr, brr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}