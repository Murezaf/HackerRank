class Result
{
    //XOR
    public static int lonelyinteger(List<int> a)
    {
        int result = 0;
        foreach (var num in a)
            result ^= num;
        return result;
    }

    //HashSet
    //public static int lonelyinteger(List<int> a)
    //{
    //    HashSet<int> set = new HashSet<int>();

    //    for (int i = 0; i < a.Count; i++)
    //    {
    //        if (!set.Add(a[i])) //Add() function will return false if num already exists and if it doesn't exist, it will add the num to set and return true.
    //            set.Remove(a[i]);
    //    }

    //    return set.First();
    //}

    //Dictionary
    // public static int lonelyinteger(List<int> a)
    // {
    //     Dictionary<int, bool> nums = new Dictionary<int, bool>();
    //     for(int i = 0; i<a.Count(); i++)
    //     {
    //         if(!nums.ContainsKey(a[i]))
    //             nums[a[i]] = true;
    //         else
    //             nums[a[i]] = false;
    //     }
    //     return nums.FirstOrDefault(x => x.Value == true).Key;
    // }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.lonelyinteger(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
