class Result
{
    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<int, int> countPerBird = new Dictionary<int, int>();
 
        for (int i = 0; i < arr.Count; i++)
        {
            if(countPerBird.ContainsKey(arr[i]))
                countPerBird[arr[i]]++;
            else
                countPerBird[arr[i]] = 1;
        }

        int maxCountPerBird = 0;
        foreach(int value in countPerBird.Values)
        {
            if (value > maxCountPerBird)
                maxCountPerBird = value;
        }
        //int max_numberof_eachbird = countPerBird.Values.Max();

        int minIdOfBirds = int.MaxValue;
        foreach(int key in countPerBird.Keys)
        {
            if (key < minIdOfBirds && countPerBird[key] == maxCountPerBird)
                minIdOfBirds = key;
        }
        //int minIdOfBirds = countPerBird.Keys.Min();

        return minIdOfBirds;

        //return countPerBird
        //    .Where(bird => bird.Value == maxCountPerBird)
        //    .Select(bird => bird.Key)
        //    .Min();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}