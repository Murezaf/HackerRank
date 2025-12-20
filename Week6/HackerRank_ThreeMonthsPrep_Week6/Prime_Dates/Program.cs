//This was a debugging challenge: commented lines had logical issues during debugging process and were corrected in their following lines.
using System.Text.RegularExpressions;

class Solution
{
    static List<int> month = new List<int>();

    static void updateLeapYear(int year)
    {
        if (year % 400 == 0)
        {
            //month[2] = 28;
            month[2] = 29;
        }
        else if (year % 100 == 0)
        {
            //month[2] = 29;
            month[2] = 28;
        }
        else if (year % 4 == 0)
        {
            month[2] = 29;
        }
        else
        {
            month[2] = 28;
        }
    }

    static void storeMonth()
    {
        month[1] = 31;
        month[2] = 28;
        month[3] = 31;
        month[4] = 30;
        month[5] = 31;
        month[6] = 30;
        month[7] = 31;
        month[8] = 31;
        month[9] = 30;
        month[10] = 31;
        month[11] = 30;
        month[12] = 31;
    }

    static int findPrimeDates(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        storeMonth();
        int numberOfLuckyDates = 0;

        while (true)
        {
            int x = d1;
            x = x * 100 + m1;
            //x = x * 1000 + y1;
            x = x * 10000 + y1;

            //if (x % 4 == 0 && x % 7 == 0)
            if (x % 4 == 0 || x % 7 == 0)
            {
                numberOfLuckyDates = numberOfLuckyDates + 1;
            }

            if (d1 == d2 && m1 == m2 && y1 == y2)
            {
                break;
            }

            updateLeapYear(y1);
            d1 = d1 + 1;

            if (d1 > month[m1])
            {
                m1 = m1 + 1;
                d1 = 1;

                if (m1 > 12)
                {
                    y1 = y1 + 1;
                    //m1 = m1 + 1;
                    m1 = 1;
                }
            }
        }

        return numberOfLuckyDates;
    }

    static void Main()
    {
        for (int i = 1; i < 15; i++)
        {
            month.Add(31);
        }

        string line = Console.ReadLine();
        string[] date = Regex.Split(line, "-| ");

        int d1 = int.Parse(date[0]);
        int m1 = int.Parse(date[1]);
        int y1 = int.Parse(date[2]);
        int d2 = int.Parse(date[3]);
        int m2 = int.Parse(date[4]);
        int y2 = int.Parse(date[5]);

        int result = findPrimeDates(d1, m1, y1, d2, m2, y2);
        Console.WriteLine(result);
    }
}