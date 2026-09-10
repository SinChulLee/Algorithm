using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        for(int i = 2; i <= 8; i++)
        {
            if(i % 2 == 0)
            {
                for(int j = B; j >= A; j--)
                {
                    Console.Write($"{j} * {i} = {j*i}");
                    if(j != A)
                        Console.Write(" / ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
