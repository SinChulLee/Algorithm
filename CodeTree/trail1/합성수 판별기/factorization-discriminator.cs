using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        bool isSatisfied = false;

        for (int i = 2; i < N; i++)
        {
            if (N % i == 0)
                isSatisfied = true;
        }

        if (isSatisfied)
            Console.Write("C");
        else
            Console.Write("N");
    }
}
