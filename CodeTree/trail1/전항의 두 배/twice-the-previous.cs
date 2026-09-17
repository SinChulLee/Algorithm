using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = new int[10];
        arr[0] = int.Parse(input[0]);
        arr[1] = int.Parse(input[1]);

        for(int i = 2; i < 10; i++)
        {
            arr[i] = 2 * arr[i-2] + arr[i-1];
        }

        for(int j = 0; j < 10; j++)
        {
            Console.Write($"{arr[j]} ");
        }
    }
}
