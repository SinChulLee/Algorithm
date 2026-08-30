using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        double avg;

        for(int i = 1; i <= N; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }
        avg = (double)sum/N;
        
        Console.Write($"{sum} {avg:F1}");
    }
}
