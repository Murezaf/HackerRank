class Result
{
    public static int sockMerchant(int n, List<int> ar)
    {
        Dictionary<int, int> numberof_eachsock = new Dictionary<int, int>(); int result = 0;    
        for (int i = 0; i < ar.Count; i++)
        {
            if(numberof_eachsock.ContainsKey(ar[i]))
                numberof_eachsock[ar[i]]++;
            else
                numberof_eachsock[ar[i]] = 1;
        }
        foreach (int numberof_sock in numberof_eachsock.Values)
            result += numberof_sock / 2;
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}