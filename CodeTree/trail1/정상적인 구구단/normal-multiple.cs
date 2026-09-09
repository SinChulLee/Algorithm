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
                if(j != N)
                    Console.Write($"{i} * {j} = {i*j}, ");
                else
                    Console.Write($"{i} * {j} = {i*j}");
            }
            Console.WriteLine();
        }
    }
}
