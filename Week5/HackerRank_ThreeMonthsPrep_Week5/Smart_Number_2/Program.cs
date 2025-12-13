//This was a debugging challenge: commented lines had logical issues during debugging process and were corrected in their following lines.
class Result
{
    public static bool IsSmartNumber(int number)
    {
        int root = (int)Math.Sqrt(number);

        //if (number / root == 1)
        if (root * root == number)
        {
            return true;
        }
        return false;
    }
}
//A number's factors usually come in pairs (like 2 & 8 for 16). Only perfect squares have one unpaired factor (like 4 for 16), which makes the total number of factors odd. Therefore, a number is smart if and only if its square root is an integer.

class Solution
{ 
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            bool answer = Result.IsSmartNumber(number);

            if (answer)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}