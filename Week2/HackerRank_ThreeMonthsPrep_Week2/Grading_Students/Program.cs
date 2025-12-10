class Result
{
    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> finalGrades = new List<int>();

        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] >= 38)
            {
                finalGrades.Add(UpdateGrade(grades[i]));
            }
            else
                finalGrades.Add(grades[i]);
        }
        return finalGrades;
    }

    public static int UpdateGrade(int grade)
    {
        int temp = grade % 5;
        int nextMultipleOfFive = grade + (5 - temp);
        if (nextMultipleOfFive - grade < 3)
            grade = nextMultipleOfFive;

        return grade;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}