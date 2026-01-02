class Result
{
    public static int pylons(int k, List<int> arr)
    {
        int count = 0; int currentIndex = 0; bool foundPlant = false;

        while (currentIndex < arr.Count)
        {
            foundPlant = false;

            for (int farestPowerPlantPossible = Math.Min(arr.Count - 1, currentIndex + k - 1); farestPowerPlantPossible >= Math.Max(0, currentIndex - (k - 1)); farestPowerPlantPossible--)
            {
                if (arr[farestPowerPlantPossible] == 1)
                {
                    count++;
                    foundPlant = true;
                    currentIndex = farestPowerPlantPossible + k;
                    break;
                }
            }

            if (!foundPlant)
                return -1;
        }

        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.pylons(k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}