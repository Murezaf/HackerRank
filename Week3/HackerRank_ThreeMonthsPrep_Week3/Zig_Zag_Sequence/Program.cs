//This was a debugging challenge: commented lines had logical issues during debugging process and were corrected in their following lines.
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

        int firstPointer = mid + 1;
        //int second_pointer = n - 1;
        int secondPointer = n - 2;

        while (firstPointer <= secondPointer)
        {
            temp = list[firstPointer];
            list[firstPointer] = list[secondPointer];
            list[secondPointer] = temp;

            firstPointer++;
            //secondPointer++;
            secondPointer--;
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