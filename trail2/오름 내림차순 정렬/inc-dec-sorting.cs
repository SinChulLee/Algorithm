using System;

public class Codetree
{  
    public static void PrintArr(int n, int[] arr)
    {
        for(int i = 0; i < n; i++)
            Console.Write($"{arr[i]} ");
        Console.WriteLine();
    }

    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Array.Sort(arr);
        PrintArr(n, arr);
        Array.Sort(arr, (a,b) => b.CompareTo(a));
        // Array.Reverse(arr);
        PrintArr(n, arr);
    }
}
