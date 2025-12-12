class Result
{
    public static int pageCount(int n, int p)
    {
        int visiblePage = 1; int middle = n / 2; int count = 0;

        if (p <= middle)
        {
            while (p > visiblePage)
            {
                visiblePage += 2;
                count++;
            }

            return count;
        }

        else
        {
            if (n % 2 == 1)
                visiblePage = n - 1;
            else
            {
                visiblePage = n;
            }
            //According to the shape of the book given in the question

            while (p < visiblePage)
            {
                visiblePage -= 2;
                count++;
            }

            return count;
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}