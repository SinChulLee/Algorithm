using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int sum = 0;
        int cnt = 0;

        for (int i = 0; i < 10; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 200)
            {
                sum += num;
                cnt += 1;
            }
        }
        double avg = (double)sum/cnt;
        Console.Write($"{sum} {avg:F1}");
    }
}
