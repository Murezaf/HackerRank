class Result
{
    public static long sumXor(long n)
    {
        long zeroBitCount = 0;

        while (n > 0)
        {
            if ((n & 1) == 0)
            {
                zeroBitCount++;
            }
            n = n >> 1;
        }

        return (long)Math.Pow(2, zeroBitCount);
    }
}
//n + x is equal to n XOR x only when no carry happens in binary addition.
//we look at the bits of n:
//If a bit in n is 1, x must be 0 there (otherwise carry happens).
//If a bit in n is 0, x can be 0 or 1.
// that’s why the answer is 2^(number of zero bits in n).

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.sumXor(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}