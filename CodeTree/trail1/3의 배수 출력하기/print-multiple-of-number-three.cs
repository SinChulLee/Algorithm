using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int Count = 3;
        while(Count <= N)
        {
            Console.Write($"{Count} ");
            Count += 3;
        }
    }
}
