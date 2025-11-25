namespace Solution
{
    public class Result
    {
        public static string XOR_String(string first, string second)
        {
            char[] result = new char[first.Length];
            for (int i = 0; i < first.Length; i++)
                if(first[i] == second[i])
                    result[i] = '0';
                else
                    result[i] = '1';
                //result[i] = (first[i] == second[i]) ? '0' : '1';
            return new string(result);
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            string first_line = Console.ReadLine();
            string second_line = Console.ReadLine();

            Console.Write(Result.XOR_String(first_line, second_line));
        }
    }
}