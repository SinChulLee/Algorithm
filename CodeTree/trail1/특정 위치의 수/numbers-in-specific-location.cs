using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);
        int ans = arr[2] + arr[4] + arr[9];
        Console.Write(ans);
    }
}
