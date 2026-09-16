using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);

        for(int i = 0; i < N; i++)
        {
            arr[i] *= arr[i];
            Console.Write($"{arr[i]} ");
        }

    }
}
