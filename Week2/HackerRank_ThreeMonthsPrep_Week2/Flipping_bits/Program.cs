class Result
{
    public static long flippingBits(long n)
    {
        return 4294967295 - n;
    }
    //A 32‑bit number with all bits set to 1 == 2^32 - 1 == 4294967295
    // Subtracting n from this value flips every bit of n, because each 1 becomes 0 and each 0 becomes 1.

    //public static long flippingBitss(long n)
    //{
    //    long result = 0; List<int> digits = new List<int>();
    //    for (int i = 0; i < 32; i++)
    //        digits.Add(0);

    //    //having n in binary format
    //    for (int i = digits.Count; i >= 0; i--)
    //    {
    //        if (n == 0)
    //            break;
    //        if (n >= (long)Math.Pow(2, i))
    //        {
    //            digits[i] = 1;
    //            n -= (long)Math.Pow(2, i);
    //        }
    //    }
        
    //    //flipping n
    //    for (int i = 0; i < digits.Count; i++)
    //    {
    //        if (digits[i] == 1)
    //            digits[i] = 0;
    //        else
    //            digits[i] = 1;
    //    }

    //    //convert from binary to decimal
    //    for (int i = 0; i < digits.Count; i++)
    //    {
    //        if (digits[i] == 1)
    //            result += (long)Math.Pow(2, i);
    //    }

    //    return result;
    //}
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