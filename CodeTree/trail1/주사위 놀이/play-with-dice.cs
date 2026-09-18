using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);
        int[] ansarr = new int[6];

        for(int i = 0; i < 10; i++)
        {
            for(int j = 1; j <= 6; j++)
            {
                if(arr[i] == j)
                    ansarr[j-1] += 1;
            }
        }

        for(int k = 0; k < 6; k++)
        {
            Console.WriteLine($"{k+1} - {ansarr[k]}");
        }
    }
}
