class Result
{
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v1 == v2)
        {
            if (x1 == x2)
                return "YES";
            return "NO";
        }    

        int exact_turn = (x2 - x1) / (v1 - v2);
        if (exact_turn < 0)
            return "NO";

        if (x1 + exact_turn * v1 == x2 + exact_turn * v2)
            return "YES";
        return "NO";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}