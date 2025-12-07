class Result
{
    public static string caesarCipher(string s, int k)
    {
        string result = ""; k = k % 26;
        foreach (char character in s)
        {
            if (character >= 65 && character <= 90)
            {
                if (character + k > 90)
                {
                    result += (char)(character + k - 26);
                }
                else
                    result += (char)(character + k);
            }

            else if (character >= 97 && character <= 122)
            {
                if (character + k > 122)
                {
                    result += (char)(character + k - 26);
                }
                else
                    result += (char)(character + k);
            }

            else
                result += character;
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}