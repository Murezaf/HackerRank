class Result
{
    public static int minimumNumber(int n, string password)
    {
        Dictionary<string, bool> conditions = new Dictionary<string, bool>(); int countCharacterNeed = 0;
        List<char> specialCharacters = new List<char>() { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' };

        for (int i = 0; i < n; i++)
        {
            if (!conditions.ContainsKey("lowercase") && (password[i] >= 97 && password[i] <= 122))
                conditions["lowercase"] = true;

            else if (!conditions.ContainsKey("uppercase") && (password[i] >= 65 && password[i] <= 90))
                conditions["uppercase"] = true;

            else if (!conditions.ContainsKey("numbers") && int.TryParse(password[i].ToString(), out int x))
                conditions["number"] = true;

            else if (!conditions.ContainsKey("specialcharacter") && specialCharacters.Contains(password[i]))
                conditions["specialcharacter"] = true;
        }

        countCharacterNeed = 4 - conditions.Count;
        n += 4 - conditions.Count;

        if(n < 6)
            countCharacterNeed += (6 - n);

        return countCharacterNeed;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        int answer = Result.minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}