//Q4
//Test Results : All available test cases passed
class Result
{
    /*
     * Complete the 'isNonTrivialRotation' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts following parameters:
     *  1. STRING s1
     *  2. STRING s2
     */

    public static bool isNonTrivialRotation(string s1, string s2)
    {
        if (s1 == s2) { return false; }
        string result = "";
        for (int i = 1; i < s1.Count(); i++)
        {
            for (int j = 0; j < s1.Count(); j++)
            {
                result += s1[(j + i) % s1.Count()];
            }
            if (result == s2) { return true; }
            result = "";
        }
        return false;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string s1 = Console.ReadLine();

        string s2 = Console.ReadLine();

        bool result = Result.isNonTrivialRotation(s1, s2);

        Console.WriteLine((result ? 1 : 0));
    }
}