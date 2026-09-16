using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);
        int sum = 0;
        int sum2 = 0;
        int cnt = 0;
        double avg = 0;
        for(int i = 0; i < 10; i++)
        {
            if(i % 2 == 1)
                sum += arr[i];
            
            if(i % 3 == 2)
            {
                sum2 += arr[i];
                cnt++;
            }
        }
        avg = (double)sum2/cnt;
        Console.Write($"{sum} {avg:F1}");
    }
}
