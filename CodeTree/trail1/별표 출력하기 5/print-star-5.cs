using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for(int i = N; i > 0; i--)
        {
            for(int j = i; j > 0; j--)
            {
                for(int h = 0; h < i; h++)
                {
                    Console.Write('*');
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
