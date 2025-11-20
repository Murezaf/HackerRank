class Result
{
    public static int QuickSelect(List<int> arr, int k)
    {
        int pivot = arr[arr.Count / 2];

        List<int> less = new List<int>();
        List<int> equal = new List<int>();
        List<int> greater = new List<int>();

        foreach (int x in arr)
        {
            if (x < pivot) less.Add(x);
            else if (x > pivot) greater.Add(x);
            else equal.Add(x);
        }

        if (k < less.Count)
            return QuickSelect(less, k);

        else if (k < less.Count + equal.Count)
            return pivot;

        else
            return QuickSelect(greater, k - less.Count - equal.Count);
    }
    public static int findMedian(List<int> arr)
    {
        return QuickSelect(arr, arr.Count/2);
    }
    // Time Complexity:
    // Average Case: O(n) 
    // QuickSelect only searches the side containing the k-th element(for median k is n/2), not the entire array.

    //public static List<int> QuickSort(List<int> arr)
    //{
    //    if (arr.Count <= 1)
    //        return arr;

    //    int pivot = arr[arr.Count / 2];
    //    List<int> lessthan_pivot = new List<int>();
    //    List<int> equalto_pivot = new List<int>();
    //    List<int> greaterthan_pivot = new List<int>();

    //    foreach (int i in arr)
    //    {
    //        if (i > pivot)
    //            greaterthan_pivot.Add(i);
    //        else if (i < pivot)
    //            lessthan_pivot.Add(i);
    //        else 
    //            equalto_pivot.Add(i);
    //    }

    //    List<int> result = new List<int>();
    //    result.AddRange(QuickSort(lessthan_pivot));
    //    result.AddRange(equalto_pivot);
    //    result.AddRange(QuickSort(greaterthan_pivot));

    //    return result;
    //}
    //public static int findMedian(List<int> arr)
    //{
    //    List<int> sorted_arr = QuickSort(arr);
    //    return sorted_arr[sorted_arr.Count / 2];
    //}
    // Time Complexity:
    // Average Case: O(n log n) because because of QuickSort
    // QuickSort sorts the entire array, even though we may only need the median
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.findMedian(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}