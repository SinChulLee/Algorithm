using System;

public class Codetree
{  
    public static int f(int n)
    {
        if(n < 10)
            return n;
        
        return f(n/10) + n % 10;
    }

    public static void Main()
    {
        // Please write your code here.
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int mul = arr[0]*arr[1]*arr[2];
        Console.Write(f(mul));
    }
}
