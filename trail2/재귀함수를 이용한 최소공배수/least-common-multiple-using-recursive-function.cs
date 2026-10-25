using System;

public class Codetree
{  
    public static int GCD(int a, int b)
    {
        if (b == 0)
            return a;

        return GCD(b, a % b);
    }

    public static int LCM(int a, int b)
    {
        return a / GCD(a, b) * b;
    }

    public static int F(int n, int[] arr, int idx)
    {
        if (idx == n - 1)
            return arr[idx];

        return LCM(arr[idx], F(n, arr, idx + 1));
    }

    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.Write(F(n,arr,0));
    }
}
