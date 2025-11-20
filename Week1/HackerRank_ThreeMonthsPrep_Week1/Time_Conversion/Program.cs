class Result
{
    public static string timeConversion(string s)
    {
        //string hours = $"{s[0]}{s[1]}"; string minutes = $"{s[3]}{s[4]}"; string seconds = $"{s[6]}{s[7]}"; string status = $"{s[8]}{s[9]}";
        
        //string[] time = s.Split(':');
        //string hours = time[0]; string minutes = time[1]; string seconds = time[2][0].ToString(); seconds += time[2][1]; string status = time[2][2].ToString(); status += time[2][3];
        
        string hours = s.Substring(0, 2); string minutes = s.Substring(3, 2); string seconds = s.Substring(6, 2); string status = s.Substring(8, 2);
        if (status == "AM")
        {
            int inthours = int.Parse(hours) % 12;
            if (inthours < 10)
                hours = $"0{inthours.ToString()}";
            return $"{hours}:{minutes}:{seconds}";
        }
        else
            return $"{int.Parse(hours) % 12 + 12}:{minutes}:{seconds}";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}