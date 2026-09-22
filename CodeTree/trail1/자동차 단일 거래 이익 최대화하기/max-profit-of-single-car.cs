using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int max = 0;

        for(int i = 0; i < N; i++)
        {
            for(int j = i+1; j < N; j++)
            {
                if(arr[j] - arr[i] > max)
                    max = arr[j] - arr[i];
            }
        }

        Console.Write(max);

    }
}
