using System;

public class Codetree
{
    public static int[] Convert(int n, int[] arr)
    {   
        for(int i = 0; i < n; i++)
        {
            if(arr[i] % 2 == 0)
            {
                arr[i] = arr[i] / 2;
            } 
        }
        return arr;                
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Convert(n, arr);
        for(int i = 0; i < n; i++)
        {
            Console.Write($"{arr[i]} ");
        }
    }
}