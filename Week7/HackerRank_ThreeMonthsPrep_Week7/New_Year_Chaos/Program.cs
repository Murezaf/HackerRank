using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Result
{
    public static void minimumBribes(List<int> q)
    {
        int bribes = 0; //The idea of ​​finding the number of bribes is to count for each number x in the list, the numbers greater than x but with an index less than index of x.

        for (int i = 0; i < q.Count; i++)
        {
            if (q[i] - (i + 1) > 2)
            {
                Console.WriteLine("Too chaotic");
                return;
            }

            if (q[i] > 1) 
            {
                for (int j = (q[i] - 1) - 1; j < i; j++) //According to the rules stated in the question, the index range of numbers greater than any number x, can be from one less than the index x in the initial state(x - 1) upwards.
                {
                    if (q[j] > q[i])
                        bribes++;
                }
            }
            else
            {
                for (int j = 0; j < i; j++)
                {
                    if (q[j] > q[i])
                        bribes++;
                }
            }
        }

        Console.WriteLine(bribes);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            Result.minimumBribes(q);
        }
    }
}