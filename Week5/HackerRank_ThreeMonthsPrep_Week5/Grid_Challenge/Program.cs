class Result
{
    public static string gridChallenge(List<string> grid)
    {
        int numberOfRows = grid.Count; int numberOfColumns = grid[0].Length;

        //Sorting rows
        for(int i = 0; i < numberOfRows; i++)
        {
            char[] charactersOfRow = grid[i].ToArray();
            Array.Sort(charactersOfRow);
            grid[i] = new string(charactersOfRow);
        }

        //Checking for order in columns
        for (int column = 0; column < numberOfColumns; column++)
        {
            for(int row = 0; row < numberOfRows-1; row++)
            {
                if (grid[row][column] > grid[row + 1][column])
                    return "NO";
            }
        }

        return "YES";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            string result = Result.gridChallenge(grid);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}