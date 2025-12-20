using System.Numerics;

class Result
{
    public static BigInteger fibonacciModified(int t1, int t2, int n)
    {
        BigInteger temp = 0; BigInteger last = t2; BigInteger beforeLast = t1;

        for (int i = 1; i < n - 1; i++)
        {
            temp = beforeLast + (last * last);

            beforeLast = last;
            last = temp;
        }

        return last;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int t1 = Convert.ToInt32(firstMultipleInput[0]);

        int t2 = Convert.ToInt32(firstMultipleInput[1]);

        int n = Convert.ToInt32(firstMultipleInput[2]);

        BigInteger result = Result.fibonacciModified(t1, t2, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}