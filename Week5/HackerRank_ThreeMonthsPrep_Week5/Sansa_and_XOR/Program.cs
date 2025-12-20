class Result
{
    public static int sansaXor(List<int> arr)
    {
        int result = 0;

        if(arr.Count %  2 == 0) 
            return 0;

        for(int i = 0; i < arr.Count; i+=2)
            result ^= arr[i];

        return result;
    }
    //If the array length is even, every element appears an even number of times in the final XOR result. XOR of even occurrences cancels out, so the answer is 0.
    //When the array length is odd, only elements at even indices appear an odd number of times across all subarrays. Only those elements contribute to the final XOR. Ex: [a,b,c]: a ^ b ^ c ^ (a^b) ^ (b^c) ^ (a^b^c) => a and c appear 3 times but b appears 4 times.

    //public static int sansaXor(List<int> arr)
    //{
    //    List<int> results = new List<int>(); int finalResult = 0; int temp = 0;

    //    for (int i = 0; i < arr.Count; i++)
    //    {
    //        results.Add(arr[i]);
    //        if (i == arr.Count - 1)
    //            break;
    //        temp = arr[i];
    //        for(int j = i+1; j < arr.Count; j++)
    //        {
    //            temp = temp ^ arr[j];
    //            results.Add(temp);
    //        }
    //    }

    //    foreach(int result in results)
    //        finalResult ^= result;

    //    return finalResult;
    //}
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.sansaXor(arr);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
