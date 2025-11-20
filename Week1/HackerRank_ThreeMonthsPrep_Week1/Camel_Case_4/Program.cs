class Result
{
    public static string Split_or_Create(string input)
    {
        string[] operation_parts = input.Split(';');
        string result = "";
        if (operation_parts[0] == "S")
        {
            result += operation_parts[2][0].ToString().ToLower();
            if (operation_parts[1] == "M")
            {
                for (int i = 1; i < operation_parts[2].Length - 2; i++)
                {
                    if (operation_parts[2][i].ToString() != operation_parts[2][i].ToString().ToLower())
                    {
                        result += " ";
                        result += operation_parts[2][i].ToString().ToLower();
                    }
                    else
                    {
                        result += operation_parts[2][i];
                    }
                }
            }
            else
            {
                for (int i = 1; i < operation_parts[2].Length; i++)
                {
                    if (operation_parts[2][i].ToString() != operation_parts[2][i].ToString().ToLower())
                    {
                        result += " ";
                        result += operation_parts[2][i].ToString().ToLower();
                    }
                    else
                    {
                        result += operation_parts[2][i];
                    }
                }
            }
        }
        if (operation_parts[0] == "C")
        {
            string[] words = operation_parts[2].Split(" ");
            if (operation_parts[1] == "M")
            {
                result += words[0];
                for (int i = 1; i < words.Length; i++)
                {
                    result += words[i][0].ToString().ToUpper();
                    result += words[i].ToString().Substring(1);
                }
                result += "()";
            }
            else if (operation_parts[1] == "C")
            {
                for (int i = 0; i < words.Length; i++)
                {
                    result += words[i][0].ToString().ToUpper();
                    result += words[i].ToString().Substring(1);
                }
            }
            else if (operation_parts[1] == "V")
            {
                result += words[0];
                for (int i = 1; i < words.Length; i++)
                {
                    result += words[i][0].ToString().ToUpper();
                    result += words[i].ToString().Substring(1);
                }
            }
        }
        return result;
    }
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