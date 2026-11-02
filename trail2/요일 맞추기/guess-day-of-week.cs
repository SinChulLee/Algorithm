using System;

public class Codetree
{  
    public static int[] Months = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    public static string[] Days = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};

    public static int DiffDays(int m1, int d1, int m2, int d2)
    {
        int days1 = d1; int days2 = d2;
        for(int i = 0; i < m1; i++)
            days1 += Months[i];
        for(int j = 0; j < m2; j++)
            days2 += Months[j];
        
        return days2-days1;
    }

    public static string WhereDays(int diffdays)
    {
        diffdays = diffdays % 7;
        if(diffdays < 0)
            diffdays = 7 + diffdays;
        return Days[0+diffdays];
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int m1 = int.Parse(input[0]);
        int d1 = int.Parse(input[1]);
        int m2 = int.Parse(input[2]);
        int d2 = int.Parse(input[3]);

        int diffdays = DiffDays(m1,d1,m2,d2);
        string day = WhereDays(diffdays);
        Console.Write(day);
    }
}
