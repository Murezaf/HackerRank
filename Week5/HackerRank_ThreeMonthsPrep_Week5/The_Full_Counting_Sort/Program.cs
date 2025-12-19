using System.Collections.Immutable;
using System.Text;

class Result
{
    public static void countSort(List<List<string>> arr)
    {
        Dictionary<int, StringBuilder> map = new Dictionary<int, StringBuilder>(); StringBuilder result = new StringBuilder();

        for (int i = 0; i < arr.Count / 2; i++)
            arr[i][1] = "-";

        foreach (var pair in arr)
        {
            int key = int.Parse(pair[0]);
            string value = pair[1];

            if (!map.ContainsKey(key))
                map[key] = new StringBuilder();

            map[key].Append(value);
            map[key].Append(' ');
        }

        //var sortedMap = map.OrderBy(x => x.Key);
        ////IOrderedEnumerable<KeyValuePair<int, StringBuilder>> sortedMap = map.OrderBy(x => x.Key);

        //foreach (KeyValuePair<int, StringBuilder> pair in sortedMap)
        //    result.Append(pair.Value);

        List<int> keys = new List<int>(map.Keys);
        keys.Sort();

        foreach (var key in keys)
            result.Append(map[key]);

        Console.WriteLine(result.ToString().Trim());
    }
}
//Using StringBuilder for efficient string concatenation.
//Direct 'string +=' operations are slow due to string immutability (a new object of string creates each time). Leading to performance issues like Time Limit Exceeded (TLE) for large data.

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<string>> arr = new List<List<string>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        Result.countSort(arr);
    }
}