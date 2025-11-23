class Result
{
    public static string Split_or_Create(string input)
    {
        string[] parts = input.Split(';');
        string op = parts[0];
        string type = parts[1];
        string content = parts[2];

        if (op == "S")
            return SplitCamel(content, type);
        else
            return CombineCamel(content, type);
    }

    private static string SplitCamel(string text, string type)
    {
        char[] chars = text.ToCharArray(); int length = chars.Length; char character;

        if (type == "M")
            length -= 2;

        List<char> result = new List<char>();

        for (int i = 0; i < length; i++)
        {
            character = chars[i];
            if (character >= 'A' && character <= 'Z')
            {
                if (i == 0)
                    result.Add((char)(character + 32));
                else
                {
                    result.Add(' ');
                    result.Add((char)(character + 32));
                }
            }
            else
            {
                result.Add(character);
            }
        }

        return new string(result.ToArray());
    }

    private static string CombineCamel(string text, string type)
    {
        char[] chars = text.ToCharArray();
        List<char> result = new List<char>();

        int index = 0;
        while (index < chars.Length)
        {
            char character = chars[index];
            if (character == ' ')
            {
                index++;
                character = chars[index];
                result.Add((char)(character - 32));
            }
            else
            {
                result.Add(character);
            }
            index++;
        }

        if (type == "M")
        {
            result.Add('(');
            result.Add(')');
        }
        else if (type == "C")
        {
            result[0] = (char)(result[0] - 32);
        }

        return new string(result.ToArray());
    }

    public class Solution
    {
        static void Main(String[] args)
        {
            string input = Console.ReadLine();
            List<string> result = new List<string>();
            while (input != null)
            {
                result.Add(Result.Split_or_Create(input));
                input = Console.ReadLine();
            }
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}