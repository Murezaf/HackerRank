class BigNumberComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        if (x.Length != y.Length)
            return x.Length.CompareTo(y.Length);
        // < 0  => x has fewer digits, so x should come before y
        // > 0  => x has more digits, so x should come after y

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] != y[i])
            {
                return x[i].CompareTo(y[i]);
                // < 0  => digit in x is smaller, x comes before y
                // > 0  => digit in x is larger, x comes after y
                //Sort only cares about the sign of this value
            }
        }

        return 0;
        //return 0 tells Sort that x and y are equal in ordering
    }
}

class Result
{
    public static List<string> bigSorting(List<string> unsorted)
    {
        unsorted.Sort(new BigNumberComparer()); //Sorts the list using the custom comparison rules defined in BigNumberComparer
        return unsorted;
    }

    //public static List<string> bigSorting(List<string> unsorted)
    //{
    //    unsorted.Sort((a, b) =>
    //    {
    //        if (a.Length != b.Length)
    //            return a.Length.CompareTo(b.Length);

    //        return CompareSameLength(a, b);
    //    });

    //    return unsorted;
    //}

    //static int CompareSameLength(string a, string b)
    //{
    //    for (int i = 0; i < a.Length; i++)
    //    {
    //        if (a[i] != b[i])
    //            return a[i] - b[i];
    //    }
    //    return 0;
    //}
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> unsorted = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string unsortedItem = Console.ReadLine();
            unsorted.Add(unsortedItem);
        }

        List<string> result = Result.bigSorting(unsorted);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}