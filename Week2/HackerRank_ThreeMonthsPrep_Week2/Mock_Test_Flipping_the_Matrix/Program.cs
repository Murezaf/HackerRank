class Result
{
    public static int flippingMatrix(List<List<int>> matrix)
    {
        int n = matrix.Count;
        int maxSum = 0;

        for (int i = 0; i < n/2; i++)
        {
            for (int j = 0; j < n/2; j++)
            {
                int a = matrix[i][j];
                int b = matrix[i][n - j - 1];
                int c = matrix[n - i - 1][j];
                int d = matrix[n - i - 1][n - j - 1];

                //maxSum += Math.Max(Math.Max(a, b), Math.Max(c, d)); //max of 4 elements(Math.Max only works for two elements)
                //maxSum += new int[4] { a, b, c, d }.Max();
                maxSum += GetMax(a, b, c, d);

                //Because of unlimited reverses, each cell in the top-left of matrix can swap with its three symmetric counterparts.
            }
        }
        return maxSum;
    }

    public static int GetMax(params int[] numbers)
    {
        //return numbers.Max();
        
        int max = -1 * int.MaxValue;
        
        foreach (int number in numbers)
        {
            if(number > max)
                max = number;
        }

        return max;
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
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < 2 * n; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            int result = Result.flippingMatrix(matrix);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}