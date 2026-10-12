using System;

public class Codetree
{  
    public static void makerect(int n, int m)
    {
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
                Console.Write(1);
            Console.WriteLine();
        }
    }
    
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        makerect(n, m);
    }
}
