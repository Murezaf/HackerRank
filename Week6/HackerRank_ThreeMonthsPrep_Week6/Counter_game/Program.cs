class Result
{
    public static string counterGame(long n)
    {
        int turn = 0; long closestPowerOfTwo = 1;

        if (n == 1)
            return "Richard";

        while (n != 1)
        {
            if ((n & (n - 1)) == 0)
                n = n / 2;

            else
            {
                while(closestPowerOfTwo * 2 < n)
                {
                    closestPowerOfTwo *= 2;
                }
                n -= closestPowerOfTwo;
                closestPowerOfTwo = 1;
            }

            turn++;
        }

        if (turn % 2 == 1)
            return "Louise";

        return "Richard";
    }



    //public static string counterGame(long n)
    //{
    //    int turn = 0;

    //    if (n == 1)
    //        return "Richard";

    //    while (n != 1)
    //    {
    //        int powerOfTwo = FindClosestPowerOfTwo(n);
    //        if (Math.Pow(2, powerOfTwo) == n)
    //            n = n / 2;
    //        else
    //            n -= (long)Math.Pow(2, powerOfTwo);

    //        turn++;
    //    }

    //    if (turn % 2 == 1)
    //        return "Louise";

    //    return "Richard";
    //}

    //public static int FindClosestPowerOfTwo(long n)
    //{
    //    int count = 0;

    //    while (n != 1)
    //    {
    //        n = n / 2;
    //        count++;
    //    }

    //    return count;
    //}
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            string result = Result.counterGame(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}