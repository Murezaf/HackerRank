public class Result
{
    public static void findZigZagSequence(List<int> list, int n)
    {
        list.Sort();

        //int mid = ((n + 1) / 2);
        int mid = ((n + 1) / 2 - 1);
        
        int temp = list[mid];
        list[mid] = list[n-1];
        list[n-1] = temp;

        int first_pointer = mid + 1;
        //int second_pointer = n - 1;
        int second_pointer = n - 2;

        while (first_pointer <= second_pointer)
        {
            temp = list[first_pointer];
            list[first_pointer] = list[second_pointer];
            list[second_pointer] = temp;

            first_pointer++;
            //second_pointer++;
            second_pointer--;
        }

        for (int i = 0; i < n; i++)
        {
            if (i == n - 1)
                Console.Write(list[i]);
            else
                Console.Write(list[i] + " ");
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

            List<int> list = new List<int>();
            string[] parts = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
                list.Add(int.Parse(parts[i]));

            Result.findZigZagSequence(list, n);
        }
    }
}