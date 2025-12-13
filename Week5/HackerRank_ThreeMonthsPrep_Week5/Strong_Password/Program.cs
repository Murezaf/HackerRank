class Result
{
    public static int minimumNumber(int n, string password)
    {
        Dictionary<string, bool> conditions = new Dictionary<string, bool>(); int countCharacterNeed = 0;

        for (int i = 0; i < n; i++)
        {
            if (conditions.Count == 4)
                break;

            if (!conditions.ContainsKey("lowercase"))
            {
                if (CheckLowerCase(password[i]))
                {
                    conditions["lowercase"] = true;
                    continue;
                }
            }

            if (!conditions.ContainsKey("uppercase"))
            {
                if (CheckUpperCase(password[i]))
                {
                    conditions["uppercase"] = true;
                    continue;
                }
            }

            if (!conditions.ContainsKey("number"))
            {
                if (CheckNumber(password[i]))
                {
                    conditions["number"] = true;
                    continue;
                }
            }

            if (!conditions.ContainsKey("specialcharacter"))
            {
                if (CheckSpecialCharacter(password[i]))
                {
                    conditions["specialcharacter"] = true;
                    continue;
                }
            }
        }

        countCharacterNeed = 4 - conditions.Count;
        n += 4 - conditions.Count;

        if(n < 6)
            countCharacterNeed += (6 - n);

        return countCharacterNeed;
    }

    static bool CheckLowerCase(char character)
    {
        if (character >= 97 && character <= 122)
            return true;
        return false;
    }
    public static bool CheckUpperCase(char character)
    {
        if (character >= 65 && character <= 90)
            return true;
        return false;
    }
    public static bool CheckNumber(char character)
    {
        if (int.TryParse(character.ToString(), out int x))
            return true;
        return false;
    }
    public static bool CheckSpecialCharacter(char character)
    {
        List<char> specialCharacters = new List<char>() { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' };
        if (specialCharacters.Contains(character))
            return true;
        return false;
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