//Q3
//Test Results : All available test cases passed
class Result
{
    public static bool isAlphabeticPalindrome(string code)
    {
        List<char> letters = new List<char>();

        for(int i = 0; i < code.Length; i++)
        {
            if(char.IsLetter(code[i]))
                letters.Add(code[i]);
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