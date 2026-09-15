using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(input, int.Parse);
        int cnt = 0;
        int sum = 0;

        for(int i = 0; i < 10; i++)
        {
            if(array[i] == 0)
                break;
            sum += array[i];
            cnt++;
        }
        Console.Write($"{sum} {(double)sum/cnt:F1}");
    }
}
