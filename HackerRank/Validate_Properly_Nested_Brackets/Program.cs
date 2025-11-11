//Q8
//Test Results : All available test cases passed
class Result
{
    /*
     * Complete the 'areBracketsProperlyMatched' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts STRING code_snippet as parameter.
     */

    public static bool areBracketsProperlyMatched(string code_snippet)
    {
        List<char> brackets = new List<char>();
        foreach (char charecter in code_snippet)
        {
            if (charecter == '[' || charecter == '(' || charecter == '{')
            {
                brackets.Add(charecter);
            }
            if (charecter == ']')
            {
                if (brackets.Count() == 0) { return false; }
                if (last_orgin(brackets) == '[')
                { brackets.RemoveAt(brackets.Count - 1); }
                else { return false; }
            }
            if (charecter == ')')
            {
                if (brackets.Count() == 0) { return false; }
                if (last_orgin(brackets) == '(')
                { brackets.RemoveAt(brackets.Count - 1); }
                else { return false; }
            }
            if (charecter == '}')
            {
                if (brackets.Count() == 0) { return false; }
                if (last_orgin(brackets) == '{')
                { brackets.RemoveAt(brackets.Count - 1); }
                else { return false; }
            }
        }
        return brackets.Count == 0;
    }
    public static char last_orgin(List<char> brackets)
    {
        return brackets[brackets.Count - 1];
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        string code_snippet = Console.ReadLine();

        bool result = Result.areBracketsProperlyMatched(code_snippet);

        Console.WriteLine((result ? 1 : 0));
    }
}
