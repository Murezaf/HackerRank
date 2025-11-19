class Result
{
    public static int countingValleys(int steps, string path)
    {
        int count = 0;
        int hight = 0;
        bool under_sea = false;
        for (int i = 0; i < steps; i++)
        {
            if (path[i] == 'U')
            {
                hight += 1;
                if (under_sea == true && hight >= 0)
                {
                    count++;
                    under_sea = false;
                }
            }
            if (path[i] == 'D')
            {
                hight -= 1;
                if (hight < 0)
                    under_sea = true;
            }
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}