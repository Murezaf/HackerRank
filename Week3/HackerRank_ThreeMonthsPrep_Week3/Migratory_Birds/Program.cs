class Result
{
    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<int, int> numberof_eachbird = new Dictionary<int, int>();
        for (int i = 0; i < arr.Count; i++)
        {
            if(numberof_eachbird.ContainsKey(arr[i]))
                numberof_eachbird[arr[i]]++;
            else
                numberof_eachbird[arr[i]] = 1;
        }

        int max_numberof_eachbird = 0;
        foreach(int value in numberof_eachbird.Values)
        {
            if (value > max_numberof_eachbird)
                max_numberof_eachbird = value;
        }
        //int max_numberof_eachbird = count.Values.Max();

        int min_idof_birds = int.MaxValue;
        foreach(int key in numberof_eachbird.Keys)
        {
            if (key < min_idof_birds && numberof_eachbird[key] == max_numberof_eachbird)
                min_idof_birds = key;
        }
        return min_idof_birds;
        //return numberof_eachbird
        //    .Where(bird => bird.Value == max_numberof_eachbird)
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