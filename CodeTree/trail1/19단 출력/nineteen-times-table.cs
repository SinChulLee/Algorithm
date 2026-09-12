using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        for(int i = 1; i < 20; i++)
        {
            for(int j = 1; j < 20; j++)
            {
                Console.Write($"{i} * {j} = {i*j}");
                if(j % 2 == 0)
                    Console.WriteLine();
                else if(j == 19)
                    continue;
                else
                    Console.Write(" / ");
            }
            Console.WriteLine();
        }
    }
}
