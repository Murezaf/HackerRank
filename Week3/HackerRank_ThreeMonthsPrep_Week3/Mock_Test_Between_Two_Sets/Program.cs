class Result
{
    public static int GCDTwoIntegers(int x, int y)
    {
        int temp = 0;

        while(y != 0)
        {
            temp = y;
            y = x % y;
            x = temp;
        }

        return x;
    }

    public static int LCMTwoIntegers(int x, int y)
    {
        return (x / GCDTwoIntegers(x, y)) * y;
    }

    public static int getTotalX(List<int> a, List<int> b)
    {
        int count = 0;

        int lcm = a[0];
        foreach(int i in a) 
            lcm = LCMTwoIntegers(lcm, i);

        int gcd = b[0];
        foreach(int i in b)
            gcd = GCDTwoIntegers(gcd, i);

        for(int i = lcm; i <= gcd; i += lcm)
            if (gcd % i  == 0)
                count++;

        return count;
    }

    //public static int getTotalX(List<int> a, List<int> b)
    //{
    //    int result = 0; int maxOfFirstList = a.Max(); int minOfSecondList = b.Min(); bool valid = true;

    //    for (int i = maxOfFirstList; i <= minOfSecondList; i++)
    //    {
    //        for (int j = 0; j < a.Count; j++)
    //        {
    //            if (i % a[j] != 0)
    //            {
    //                valid = false;
    //                break;
    //            }
    //        }

    //        for (int k = 0; k < b.Count; k++)
    //        {
    //            if (b[k] % i != 0)
    //            {
    //                valid = false;
    //                break;
    //            }
    //        }

    //        if (valid)
    //            result++;
    //        else
    //            valid = true;
    //    }

    //    return result;
    //}
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}