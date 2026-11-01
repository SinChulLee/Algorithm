using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int[] numOfDays = new int[] {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        string[] input = Console.ReadLine().Split();
        int m1 = int.Parse(input[0]);
        int d1 = int.Parse(input[1]);
        int m2 = int.Parse(input[2]);
        int d2 = int.Parse(input[3]);
        int days = 0;
        while(true)
        {
            if(m1 == m2 && d1 == d2)
                break;

            days++;
            d1++;
            
            if(d1 > numOfDays[m1])
            {
                m1++;
                d1 = 1;
            }
        }

        Console.Write(days+1);
    }
}
