class Result
{
    public static List<int> rotateLeft(int d, List<int> arr)
    {
        int[] rotatedarray = new int[arr.Count];
        for (int i = 0; i < arr.Count; i++)
        {
            rotatedarray[i] = arr[(i + d) % arr.Count];
        }
        return rotatedarray.ToList<int>();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.rotateLeft(d, arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }

    //public static void Main(string[] args)
    //{
    //    int d = int.Parse(Console.ReadLine());
    //    string[] inputlist = Console.ReadLine().Split(' ');

    //    List<int> arr = new List<int>();
    //    foreach (string s in inputlist)
    //        arr.Add(int.Parse(s));

    //    List<int> ints = Result.rotateLeft(d, arr);
    //    foreach (int i in ints)
    //        Console.WriteLine(i);
    //}
}