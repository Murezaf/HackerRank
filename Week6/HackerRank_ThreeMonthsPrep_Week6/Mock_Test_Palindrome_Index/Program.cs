class Result
{
    public static int palindromeIndex(string s)
    {
        int left = 0, right = s.Length - 1;
        
        while (left < right)
        {
            if (s[left] == s[right])
            {
                left++;
                right--;
            }
        
            else
            {
                if (IsPalindrome(s, left + 1, right))
                    return left;
            
                else if (IsPalindrome(s, left, right - 1))
                    return right;
                
                else
                    return -1;
            }
        }
        return -1;
    }

    //This method is called only after one character has already been removed. From this point on, the remaining substring must stay a palindrome until the end.
    static bool IsPalindrome(string s, int l, int r)
    {
        while (l < r)
        {
            if (s[l] != s[r])
                return false;
            l++;
            r--;
        }
        return true;
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
            string s = Console.ReadLine();

            int result = Result.palindromeIndex(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}