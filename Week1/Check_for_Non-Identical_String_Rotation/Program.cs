//Q4
//Test Results : All available test cases passed
class Result
{
    public static bool isNonTrivialRotation(string s1, string s2)
    {
        if (s1 == s2) { return false; }
        string doublefirststr = s1 + s1;
        if (doublefirststr.Contains(s2))
            return true;
        return false;
    }
    //Time complexity:
    //O(n) due to Contains method

    //public static bool isNonTrivialRotation(string s1, string s2)
    //{
    //    if (s1 == s2) { return false; }
    //    string result = "";
    //    for (int i = 1; i < s1.Count(); i++)
    //    {
    //        for (int j = 0; j < s1.Count(); j++)
    //        {
    //            result += s1[(j + i) % s1.Count()];
    //        }
    //        if (result == s2) { return true; }
    //        result = "";
    //    }
    //    return false;
    //}
    /*
    Time complexity:
    - Outer loop runs n times.
    - Inner loop runs n times.
    - Each 'result += ...' on C# strings is O(n) due to immutability.(Because each time it's making a new string and copying the content of last string to the new one.)
    => Total time ~ O(n³)

    If replaced with StringBuilder(mutable), it would drop to O(n²).
    */
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