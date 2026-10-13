using System;

public class Codetree
{  
    public static void PrintMaxMul(int n, int m)
    {
        for(int i = 1; i <= n*m; i++)
        {
            if(i % n == 0 && i % m == 0)
            {
                Console.Write(i);
                break;
            }
        }
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        PrintMaxMul(n,m);
    }
}
