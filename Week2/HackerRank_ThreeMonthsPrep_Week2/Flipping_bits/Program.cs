class Result
{
    public static long flippingBits(long n)
    {
        long result = 0;
        List<int> digits = new List<int>();
        for (int i = 0; i < 32; i++)
            digits.Add(0);

        for (int i = digits.Count; i >= 0; i--)
        {
            if (n == 0)
                break;
            if (n >= (long)Math.Pow(2, i))
            {
                digits[i] = 1;
                n -= (long)Math.Pow(2, i);
            }
        }

        for (int i = 0; i < digits.Count; i++)
        {
            if (digits[i] == 1)
                digits[i] = 0;
            else
                digits[i] = 1;
        }

        for (int i = 0; i < digits.Count; i++)
        {
            if (digits[i] == 1)
                result += (long)Math.Pow(2, i);
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}