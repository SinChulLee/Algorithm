using System;

public class Codetree
{  
    public static void PrintMaxDV(int n, int m)
    {
        int maxdv = 1;
        for(int i = 1; i <= n; i++)
        {
            if(n % i == 0 && m % i == 0)
                maxdv = i;
        }
        Console.Write(maxdv);
    }
    
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        PrintMaxDV(n,m);
    }
}
