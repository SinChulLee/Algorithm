using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int min = arr[1] - arr[0];
        
        for(int i = 0; i < N; i++)
        {
            for(int j = i+1; j < N; j++)
            {
                if(arr[j] - arr[i] < min)
                    min = arr[j] - arr[i];
            }
        }

        Console.Write(min);
    }
}
