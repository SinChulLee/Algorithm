using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Array.Sort(arr);
        Console.Write(arr[K-1]);
    }
}
