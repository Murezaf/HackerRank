//Q3
//Test Results : All available test cases passed
class Result
{

    /*
     * Complete the 'isAlphabeticPalindrome' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts STRING code as parameter.
     */
    public static bool isAlphabeticPalindrome(string code)
    {
        List<char> letters = new List<char>();

        foreach (char c in code)
        {
            if (char.IsLetter(c))
            {
                letters.Add(char.ToLower(c));
            }
        }

        int left = 0;
        int right = letters.Count - 1;

        while (left < right)
        {
            if (letters[left] != letters[right])
                return false;
            left++;
            right--;
        }

        return true;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string code = Console.ReadLine();

        bool result = Result.isAlphabeticPalindrome(code);

        Console.WriteLine((result ? 1 : 0));
    }
}
