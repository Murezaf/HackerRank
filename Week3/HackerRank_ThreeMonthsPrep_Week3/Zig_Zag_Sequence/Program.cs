public class Result
{
    public static void findZigZagSequence(List<int> a, int n)
    {
        a.Sort();

        //int mid = ((n + 1) / 2);
        int mid = ((n + 1) / 2 - 1);
        
        int temp = a[mid];
        a[mid] = a[n-1];
        a[n-1] = temp;

        int st = mid + 1;
        //int ed = n - 1;
        int ed = n - 2;

        while (st <= ed)
        {
            temp = a[st];
            a[st] = a[ed];
            a[ed] = temp;

            st++;
            //ed++;
            ed--;
        }

        for (int i = 0; i < n; i++)
        {
            if (i == n - 1)
                Console.Write(a[i]);
            else
                Console.Write(a[i] + " ");
        }
    }
}

class Solution
{
    static void Main(String[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        while (testCases-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> a = new List<int>();
            string[] parts = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
                a.Add(int.Parse(parts[i]));

            Result.findZigZagSequence(a, n);
        }
    }
}