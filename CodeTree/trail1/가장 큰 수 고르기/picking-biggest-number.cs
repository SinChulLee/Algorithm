using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int max = -1;
        for(int i = 0; i < 10; i++)
        {
            if(arr[i] > max)
                max = arr[i];
        }

        Console.Write(max);
    }
}
