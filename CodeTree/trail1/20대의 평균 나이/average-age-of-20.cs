using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int sum = 0;
        int cnt = 0;
        double avg = 0.0;
        while(true)
        {
            int num = int.Parse(Console.ReadLine());
            if (num / 10 != 2)
            {
                if (cnt == 0)
                    Console.Write($"{avg:F2}");
                else
                {
                    avg = (double)sum/cnt;
                    Console.Write($"{avg:F2}");
                }
                break;
            }
            sum += num;
            cnt++;
        }
    }
}
