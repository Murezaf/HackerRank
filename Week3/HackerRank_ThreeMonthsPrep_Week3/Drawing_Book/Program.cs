class Result
{
    public static int pageCount(int n, int p)
    {
        int visible_page = 1; int middle = n / 2;
        if (p <= middle)
        {
            int count_fromfront = 0;
            while (p > visible_page)
            {
                visible_page += 2;
                count_fromfront++;
            }

            return count_fromfront;
        }

        else
        {
            int count_fromback = 0;
            if (n % 2 == 1)
                visible_page = n - 1;
            else
            {
                visible_page = n;
            }
            //According to the shape of the book given in the question

            while (p < visible_page)
            {
                visible_page -= 2;
                count_fromback++;
            }

            return count_fromback;
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