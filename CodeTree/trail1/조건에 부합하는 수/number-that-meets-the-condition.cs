using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int A = int.Parse(Console.ReadLine());

        for (int i = 1; i <= A; i++)
        {
            if (i % 2 == 0 && i % 4 != 0)
                continue;
            if ((i / 8) % 2 == 0)
                continue;
            if ((i % 7) < 4)
                continue;

            Console.Write($"{i} ");
        }
    }
}
