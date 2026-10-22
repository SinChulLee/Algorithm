using System;

public class Codetree
{  
    public static int F(int[] arr, int len, int idx, int max)
    {
        if(idx >= len)
            return max;
        if(arr[idx] > max)
            max = arr[idx];
        return F(arr, len, idx+1, max);
    }

    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.Write(F(arr, n, 1, arr[0]));
    }
}
