using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        for (int h = 0; h < 2; h++)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
    }
}
