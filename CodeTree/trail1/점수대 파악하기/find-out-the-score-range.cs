using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);
        int[] ansarr = new int[10];

        for(int i = 0 ; i < 100; i++)
        {
            if(arr[i] == 0)
                break;

            if(arr[i] < 10)
                continue;

            ansarr[arr[i] / 10 - 1]++;
        }

        for(int j = 9; j >= 0; j--)
            Console.WriteLine($"{j*10 + 10} - {ansarr[j]}");
    }
}
