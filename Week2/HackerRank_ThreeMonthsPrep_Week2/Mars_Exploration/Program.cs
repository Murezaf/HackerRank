class Result
{
    public static int marsExploration(string s)
    {
        int numberof_changes = 0; 
        for (int i = 0; i < s.Length; i++)
        {
            if((i % 3  == 0 || i % 3 == 2) && s[i] != 'S')
                numberof_changes++;
            if (i % 3 == 1 && s[i] != 'O')
                numberof_changes++;
        }

        return numberof_changes;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.marsExploration(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}