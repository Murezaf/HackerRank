class Result
{
    public static void separateNumbers(string s)
    {
        for (int i = 1; i <= s.Length / 2; i++)
        {
            string first_part = s.Substring(0, i);
            if (first_part[0] == '0')
                break;

            string buildstring = first_part;
            long first_part_num = long.Parse(first_part);

            int j = 1;
            while (buildstring.Length < s.Length)
            {
                buildstring += (first_part_num + j).ToString();
                j++;
            }

            if (buildstring == s)
            {
                Console.WriteLine($"YES {first_part}");
                return;
            }
        }
        Console.WriteLine("NO");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            Result.separateNumbers(s);
        }
    }
}