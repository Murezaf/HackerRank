class Result
{
    public static int superDigit(string n, int k)
    {
        long sumOfDigits = 0; long temp = 0;
        
        for(int i  = 0; i < n.Length; i++)
            sumOfDigits += n[i] - '0';
        sumOfDigits *= k;

        while(sumOfDigits >= 10)
        {
            while(sumOfDigits > 0)
            {
                temp += sumOfDigits % 10;
                sumOfDigits /= 10;
            }

            sumOfDigits = temp;
            temp = 0;
        }

        return (int)sumOfDigits;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.superDigit(n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}