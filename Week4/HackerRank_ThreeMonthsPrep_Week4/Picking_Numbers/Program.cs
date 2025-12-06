class Result
{
    public static int pickingNumbers(List<int> a)
    {
        int largets_length = 0; Dictionary<int, int> countof_eachnumber = new Dictionary<int, int>();
        for(int i = 0; i < a.Count; i++)
            if(countof_eachnumber.ContainsKey(a[i]))
                countof_eachnumber[a[i]]++;
            else
                countof_eachnumber[a[i]] = 1;

        int temp = 0;
        for(int i = 0; i < a.Count; i++)
        {
            if (countof_eachnumber.ContainsKey(a[i] + 1))
                temp = countof_eachnumber[a[i]] + countof_eachnumber[a[i] + 1];
            else 
                temp = countof_eachnumber[a[i]];
            
            if(temp > largets_length)
                largets_length = temp;
        }
        return largets_length;
    }

    //public static int pickingNumbers(List<int> a)
    //{
    //    int largets_length = 0;

    //    a.Sort();
    //    int temp = 0;
    //    for (int i = 0; i < a.Count - 1; i++)
    //    {
    //        for (int j = i; j < a.Count; j++)
    //        {
    //            if (a[j] - a[i] <= 1)
    //            {
    //                temp++;
    //                if (temp > largets_length)
    //                    largets_length = temp;
    //            }
    //            else
    //            {
    //                temp = 0;
    //                break;
    //            }
    //        }
    //        temp = 0;
    //    }
    //    return largets_length;
    //}
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}