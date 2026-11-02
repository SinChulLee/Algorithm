using System;

public class Codetree
{  
    public static int[] MonthDays = {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    public static string[] days = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};

    public static int DiffDays(int m1, int d1, int m2, int d2)
    {
        int totaldays1 = d1;
        int totaldays2 = d2;
        for(int i = 1; i < m1; i++)
            totaldays1 += MonthDays[i];
        for(int j = 1; j < m2; j++)
            totaldays2 += MonthDays[j];

        return totaldays2-totaldays1;
    }

    public static int CountDays(int diffdays, string day)
    {
        int count = 0;
        count += diffdays/7;
        int dayIndex = Array.IndexOf(days, day);
        if (dayIndex <= diffdays%7)
            count++;
        return count; 
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        string day = Console.ReadLine();
        int m1 = int.Parse(input[0]);
        int d1 = int.Parse(input[1]);
        int m2 = int.Parse(input[2]);
        int d2 = int.Parse(input[3]);
        int diffdays = DiffDays(m1, d1, m2, d2);
        Console.Write(CountDays(diffdays, day));
    }
}
