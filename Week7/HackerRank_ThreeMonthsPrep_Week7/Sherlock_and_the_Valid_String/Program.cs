class Result
{
    public static string isValid(string s)
    {
        Dictionary<char, int> numberOfEachCharacter = new Dictionary<char, int>();

        foreach (char character in s)
        {
            if (numberOfEachCharacter.ContainsKey(character))
                numberOfEachCharacter[character]++;
            else
                numberOfEachCharacter[character] = 1;
        }

        List<int> listOfCharacterNumbers = numberOfEachCharacter.Values.ToList();
        Dictionary<int, int> occurrenceCount = new Dictionary<int, int>();

        foreach (int number in listOfCharacterNumbers)
        {
            if(occurrenceCount.ContainsKey(number))
                occurrenceCount[number]++;

            else occurrenceCount[number] = 1;
        }

        if (occurrenceCount.Count == 1) return "YES";
        if (occurrenceCount.Count == 2)
        {
            int min = listOfCharacterNumbers.Min();
            int max = listOfCharacterNumbers.Max();
            
            if (min == 1 && occurrenceCount[min] == 1) return "YES";

            if (max == min + 1 && occurrenceCount[max] == 1) return "YES";
        }

        return "NO";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.isValid(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}