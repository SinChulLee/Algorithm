using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i < N; i++)
        {
            if (N % i == 0)
            {
                sum += i;
            }
        }

        if (N == sum)
            Console.Write("P");
        else
            Console.Write("N");
    }
}
