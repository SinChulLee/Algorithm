using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for(int i = 1; i <= N; i++)
        {
            for(int j = 1; j <= N; j++)
            {
                if (j % 2 == 1)
                    Console.Write(i);
                else
                    Console.Write(N-i+1);
            }
            Console.WriteLine();
        }
    }
}
