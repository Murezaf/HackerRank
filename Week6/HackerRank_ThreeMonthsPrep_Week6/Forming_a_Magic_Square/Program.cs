class Result
{
    //In a 3x3 magic square, numbers 1..9 are used once. Total sum of elements 1 to 9 is 45 and since there are 3 rows/columns/diagonals, so each row/column/diagonal must sum to 45 / 3 = 15.
    //There are only 8 valid 3x3 magic squares with these numbers.

    static readonly int[][][] magicSquares = new int[8][][]
    {
        new int[][] { new int[] { 8, 1, 6 }, new int[] { 3, 5, 7 }, new int[] { 4, 9, 2 } },
        new int[][] { new int[] { 6, 1, 8 }, new int[] { 7, 5, 3 }, new int[] { 2, 9, 4 } },
        new int[][] { new int[] { 4, 9, 2 }, new int[] { 3, 5, 7 }, new int[] { 8, 1, 6 } },
        new int[][] { new int[] { 2, 9, 4 }, new int[] { 7, 5, 3 }, new int[] { 6, 1, 8 } },
        new int[][] { new int[] { 8, 3, 4 }, new int[] { 1, 5, 9 }, new int[] { 6, 7, 2 } },
        new int[][] { new int[] { 4, 3, 8 }, new int[] { 9, 5, 1 }, new int[] { 2, 7, 6 } },
        new int[][] { new int[] { 6, 7, 2 }, new int[] { 1, 5, 9 }, new int[] { 8, 3, 4 } },
        new int[][] { new int[] { 2, 7, 6 }, new int[] { 9, 5, 1 }, new int[] { 4, 3, 8 } }
    };

    public static int formingMagicSquare(List<List<int>> s)
    {
        int minCost = int.MaxValue; int cost = 0;

        foreach (int[][] magicSquare in magicSquares)
        {
            cost = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cost += Math.Abs(s[i][j] - magicSquare[i][j]);
                }
            }
            if (cost < minCost)
                minCost = cost;
        }

        return minCost;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> s = new List<List<int>>();

        for (int i = 0; i < 3; i++)
        {
            s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
        }

        int result = Result.formingMagicSquare(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}