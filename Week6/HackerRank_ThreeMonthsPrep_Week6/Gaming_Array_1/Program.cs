class Result
{
    public static string gamingArray(List<int> arr)
    {
        int numberOfRemovals = 0; int max = int.MinValue;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                numberOfRemovals++;
            }
        }

        if (numberOfRemovals % 2 == 1)
            return "BOB";
        return "ANDY";
    }
}
//The game ends when the maximum element of the list becomes the first element. We can determine how many moves are played until the game reaches its ending condition.
 
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int g = Convert.ToInt32(Console.ReadLine().Trim());

        for (int gItr = 0; gItr < g; gItr++)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string result = Result.gamingArray(arr);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}