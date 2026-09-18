using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);
        int[] ansarr = new int[9];

        for(int i = 0; i < 100; i++)
        {
            if(arr[i] == 0)
                break;
            
            if(arr[i] / 10 != 0)
                ansarr[arr[i] / 10 - 1]++;
        }

        for(int j = 0; j < ansarr.Length; j++)
        {
            Console.WriteLine($"{j+1} - {ansarr[j]}");
        }
    }
}
