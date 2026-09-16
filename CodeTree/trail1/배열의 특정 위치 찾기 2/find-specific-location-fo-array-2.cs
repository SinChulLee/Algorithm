using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);
        int sum1 = 0;
        int sum2 = 0;
        for(int i = 0; i < 10; i++)
        {
            if((i + 1) % 2 == 1)
                sum1 += arr[i];
            else
                sum2 += arr[i];
        }

        if(sum1 > sum2)
            Console.Write(sum1 - sum2);
        else
            Console.Write(sum2 - sum1);
    }
}
