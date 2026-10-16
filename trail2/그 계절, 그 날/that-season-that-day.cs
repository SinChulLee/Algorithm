using System;

public class Codetree
{  
    public static bool Isyoon(int y)
    {
        if(y % 4 != 0)
            return false;
        if(y % 100 == 0)
        {
            if(y % 400 == 0)
                return true;
            return false;
        }
        return true;
    }

    public static bool IsExist(int y, int m, int d)
    {
        int[] days = { 31, 28, 31, 30, 31, 30,
                   31, 31, 30, 31, 30, 31 };
        if(Isyoon(y))
            days[1] = 29;
        
        if(m < 1 || m > 12)
            return false;
        if(d < 1 || d > days[m-1])
            return false;

        return true;
    }

    public static void PrintSeason(int m)
    {
        if(m >= 3 && m <= 5)
            Console.Write("Spring");
        else if(m >= 6 && m <= 8)
            Console.Write("Summer");
        else if(m >= 9 && m <= 11)
            Console.Write("Fall");
        else
            Console.Write("Winter");
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int Y = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        int D = int.Parse(input[2]);
        if(IsExist(Y,M,D))
            PrintSeason(M);
        else
            Console.Write(-1);
    }
}
